using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class ImageUploader
    {
        private readonly string _azureConnectionString;

        public ImageUploader (IConfiguration configuration)
        {
            _azureConnectionString = configuration.GetConnectionString("AzureConnectionString");
        }

        public async Task<string> Upload (IFormFile photo, string recipeName)
        {
            if (photo.Length > 0)
            {
                var container = new BlobContainerClient(_azureConnectionString, "upload-photo-container");
                var createResponse = await container.CreateIfNotExistsAsync();
                if (createResponse != null && createResponse.GetRawResponse().Status == 201)
                    await container.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.Blob);

                var extension = Path.GetExtension(photo.FileName);

                var shortName = String.Empty;

                if (recipeName.Length > 8)
                {
                    shortName = recipeName.Replace(" ", String.Empty).Substring(0, 8);
                }
                else
                {
                    shortName = recipeName.Replace(" ", String.Empty);
                }

                var photoName = shortName + "_" + Guid.NewGuid().ToString().Substring(0, 8) + extension;
                
                var blob = container.GetBlobClient(photoName);
                await blob.DeleteIfExistsAsync(Azure.Storage.Blobs.Models.DeleteSnapshotsOption.IncludeSnapshots);
                using (var fileStream = photo.OpenReadStream())
                {
                    await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = photo.ContentType });
                }

                return blob.Uri.ToString();
            }

            return ("File have not been saved.");
        }
    }
}

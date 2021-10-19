using DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Context
{
    public static class ModelBuilderExtensions
    {
    //    public static void Seed (this ModelBuilder modelBuilder)
    //    {
    //        #region Units
    //        Guid[] u1 = new Guid[7];

    //        for (int i = 0; i < 7; i++)
    //        {
    //            u1[i] = Guid.NewGuid();
    //        };

    //        modelBuilder.Entity<UnitEntity>().HasData(

    //            new UnitEntity { Id = u1[0], Name = "l" }, 
    //            new UnitEntity { Id = u1[1], Name = "g" },
    //            new UnitEntity { Id = u1[2], Name = "pinch" },
    //            new UnitEntity { Id = u1[3], Name = "slice" },
    //            new UnitEntity { Id = u1[4], Name = "tsp" },
    //            new UnitEntity { Id = u1[5], Name = "ml" },
    //            new UnitEntity { Id = u1[6], Name = "" }
    //            );

    //        #endregion

    //        #region Pea soup with pancetta
    //        Guid g1 = Guid.NewGuid();

    //        modelBuilder.Entity<RecipeEntity>().HasData(

    //            new RecipeEntity 
    //            { 
    //                Id = g1, 
    //                Name = "Pea soup with pancetta",
    //                Author = "Nigel Slater", 
    //                Steps =
    //                    "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.##" +
    //                    "Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.##" +
    //                    "Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp).##" +
    //                    "To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup."
    //            });

    //        Guid[] i1 = new Guid[5];

    //        for (int i = 0; i<5; i++) { i1[i] = Guid.NewGuid(); }

    //        modelBuilder.Entity<IngredientEntity>().HasData(
    //            new IngredientEntity { Id = i1[0], Name = "chicken stock" },
    //            new IngredientEntity { Id = i1[1], Name = "frozen peas" },
    //            new IngredientEntity { Id = i1[2], Name = "tarragon leaves" },
    //            new IngredientEntity { Id = i1[3], Name = "salt" },
    //            new IngredientEntity { Id = i1[4], Name = "pancetta" }
    //            );

    //        modelBuilder.Entity<RecipeIngredientEntity>().HasData(
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g1, IngredientEntityId = i1[0], Quantity=1, UnitEntityId = u1[0] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g1, IngredientEntityId = i1[1], Quantity=500, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g1, IngredientEntityId = i1[2], Quantity=10, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g1, IngredientEntityId = i1[3], Quantity=1, UnitEntityId = u1[2] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g1, IngredientEntityId = i1[4], Quantity=4, UnitEntityId = u1[3] }
    //            );
    //        #endregion

    //        #region Noodle salad with chilli nuts
    //        Guid g2 = Guid.NewGuid();

    //        modelBuilder.Entity<RecipeEntity>().HasData(

    //            new RecipeEntity
    //            {
    //                Id = g2,
    //                Name = "Noodle salad with chilli nuts",
    //                Author = "Paul Rankin",
    //                Steps =
    //                    "For the noodle salad, put the vegetable oil, soy sauce and honey in a large bowl and mix well.##" +
    //                    "Add the cucumber, pepper and cooked noodles, season with salt and pepper and mix well.##" +
    //                    "For the chilli nuts, heat the vegetable oil in a frying pan over a medium heat and fry the peanuts for 3-4 minutes. Drain off the oil and fry for a further 2-3 minutes, then add the salt and chilli and stir well to coat the nuts.##" +
    //                    "Put the noodle salad in a bowl, sprinkle over the nuts and serve."
    //            });

    //        Guid[] i2 = new Guid[10];

    //        for (int i = 0; i < 10; i++) { i2[i] = Guid.NewGuid(); }

    //        modelBuilder.Entity<IngredientEntity>().HasData(
    //            new IngredientEntity { Id = i2[0], Name = "vegetable oil" },
    //            new IngredientEntity { Id = i2[1], Name = "soy sauce" },
    //            new IngredientEntity { Id = i2[2], Name = "honey" },
    //            new IngredientEntity { Id = i2[3], Name = "cucumber" },
    //            new IngredientEntity { Id = i2[4], Name = "pepper" },
    //            new IngredientEntity { Id = i2[5], Name = "salt" },
    //            new IngredientEntity { Id = i2[6], Name = "egg noodles" }, 
    //            new IngredientEntity { Id = i2[7], Name = "black pepper" },
    //            new IngredientEntity { Id = i2[8], Name = "peanuts" },
    //            new IngredientEntity { Id = i2[9], Name = "chilli flakes" }
    //            );

    //        modelBuilder.Entity<RecipeIngredientEntity>().HasData(
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[0], Quantity = 1, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[1], Quantity = 1, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[2], Quantity = 2, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[3], Quantity = 0.25f, UnitEntityId = u1[6] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[4], Quantity = 0.25f, UnitEntityId = u1[6] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[5], Quantity = 0.5f, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[6], Quantity = 100, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[7], Quantity = 1, UnitEntityId = u1[2] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[0], Quantity = 1, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[8], Quantity = 50, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g2, IngredientEntityId = i2[9], Quantity = 0.5f, UnitEntityId = u1[4] }
    //            );
    //        #endregion

    //        #region Amaretti biscuits
    //        Guid g3 = Guid.NewGuid();

    //        modelBuilder.Entity<RecipeEntity>().HasData(

    //            new RecipeEntity
    //            {
    //                Id = g3,
    //                Name = "Amaretti biscuits",
    //                Author = "Gino D'Acampo",
    //                Steps =
    //                    "Preheat the oven to 170C/325F/Gas 3.##" +
    //                    "In a large bowl beat the egg whites until firm. Mix the sugar and the almonds gently into it. Add the amaretto liquor and fold in gently until you have a smooth paste.##" +
    //                    "Place some baking paper on a baking tray and lightly brush with butter. Using a teaspoon place small heaps of the mixture approximately 2cm/¾in apart, as they will expand while cooking. Bake for approximately 15 minutes until golden brown. Leave to cool slightly then serve or store in an air-tight container."
    //            });

    //        Guid[] i3 = new Guid[5];

    //        for (int i = 0; i < 5; i++) { i3[i] = Guid.NewGuid(); }

    //        modelBuilder.Entity<IngredientEntity>().HasData(
    //            new IngredientEntity { Id = i3[0], Name = "egg white" },
    //            new IngredientEntity { Id = i3[1], Name = "caster sugar" },
    //            new IngredientEntity { Id = i3[2], Name = "ground almonds" },
    //            new IngredientEntity { Id = i3[3], Name = "amaretto liqueur" },
    //            new IngredientEntity { Id = i3[4], Name = "butter" }
    //            );

    //        modelBuilder.Entity<RecipeIngredientEntity>().HasData(
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g3, IngredientEntityId = i3[0], Quantity = 4, UnitEntityId = u1[6] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g3, IngredientEntityId = i3[1], Quantity = 340, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g3, IngredientEntityId = i3[2], Quantity = 340, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g3, IngredientEntityId = i3[3], Quantity = 30, UnitEntityId = u1[5] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g3, IngredientEntityId = i3[4], Quantity = 1, UnitEntityId = u1[3] }
    //            );
    //        #endregion

    //        #region Madeleines
    //        Guid g4 = Guid.NewGuid();

    //        modelBuilder.Entity<RecipeEntity>().HasData(

    //            new RecipeEntity
    //            {
    //                Id = g4,
    //                Name = "Madeleines",
    //                Author = "Michel Roux Jr.",
    //                Steps =
    //                    "Preheat the oven to 200C/400F/Gas 6. Brush the madeleine tray with melted butter then shake in a little flour to coat, tapping out the excess.##" +
    //                    "Whisk together the eggs and the sugar in a bowl until frothy. Lightly whisk in the remaining ingredients. Leave to stand for 20 minutes before carefully pouring into the prepared madeleine tray.##" +
    //                    "Bake for 8-10 minutes, or until the mixture has risen a little in the middle and is fully cooked through. Transfer the madeleines to a wire rack and leave for a few minutes to cool slightly. These are best eaten within an hour of cooking."
    //            });

    //        Guid[] i4 = new Guid[6];

    //        for (int i = 0; i < 6; i++) { i4[i] = Guid.NewGuid(); }

    //        modelBuilder.Entity<IngredientEntity>().HasData(
    //            new IngredientEntity { Id = i4[0], Name = "egg" },
    //            new IngredientEntity { Id = i4[1], Name = "caster sugar" },
    //            new IngredientEntity { Id = i4[2], Name = "plain flour" },
    //            new IngredientEntity { Id = i4[3], Name = "lemon" },
    //            new IngredientEntity { Id = i4[4], Name = "baking powder" },
    //            new IngredientEntity { Id = i4[5], Name = "butter" }
    //            );

    //        modelBuilder.Entity<RecipeIngredientEntity>().HasData(
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[0], Quantity = 2, UnitEntityId = u1[6] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[1], Quantity = 100, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[2], Quantity = 100, UnitEntityId = u1[1] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[3], Quantity = 1, UnitEntityId = u1[6] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[4], Quantity = 0.75f, UnitEntityId = u1[4] },
    //            new RecipeIngredientEntity { Id = Guid.NewGuid(), RecipeEntityId = g4, IngredientEntityId = i4[5], Quantity = 100, UnitEntityId = u1[1] }

    //            );
    //        #endregion

    //    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkAndGo.DataAccess.Entity
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            AppContext context = serviceProvider.GetRequiredService<AppContext>();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Beer",
                        Price = 7.95M,
                        ShortDescription = "The most widely consumed alcohol",
                        LongDescription =
                            "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.pixabay.com/photo/2017/06/24/23/41/beer-2439237__340.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2018/05/06/08/49/beer-3378136__340.jpg"
                    },
                    new Drink
                    {
                        Name = "Rum & Coke",
                        Price = 12.95M,
                        ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription =
                            "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/rum-and-cola-cuba-libre-picture-id480045080?b=1&k=6&m=480045080&s=170667a&w=0&h=tWAvhxZoZEMPmf5OJ4AXHeeqoFrMC8s_136T1jZWl0w=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/alcohol-rum-cuba-libre-cocktail-longdrink-strong-drink-picture-id1033649272?b=1&k=6&m=1033649272&s=170667a&w=0&h=uzhRRRNnoGPJ75Nu8OHoFQKMbHZQGQwHTMofO12b5Lg="
                    },
                    new Drink
                    {
                        Name = "Tequila ",
                        Price = 12.95M,
                        ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription =
                            "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.pixabay.com/photo/2018/01/25/19/33/summer-3106910__340.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/tasty-alcohol-drink-cocktail-tequila-with-lime-and-salt-on-vibrant-picture-id692856274?b=1&k=6&m=692856274&s=170667a&w=0&h=X8Wxsr3FlkTTDilJYjDWdvn7oFlaAQAAUxsYtL3ttSs="
                    },
                    new Drink
                    {
                        Name = "Wine ",
                        Price = 16.75M,
                        ShortDescription = "A very elegant alcoholic drink",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.pixabay.com/photo/2016/10/22/20/34/wine-1761613__340.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2017/06/26/12/49/red-wine-2443699__340.jpg"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.95M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl =
                            "https://media.istockphoto.com/photos/alcoholic-margarita-cocktail-picture-id1204162066?b=1&k=6&m=1204162066&s=170667a&w=0&h=VxcoFJ3Sh4QfLk78GMxW_qBA3NEe5N9AUS_suuNqWkA=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://www.thespruceeats.com/thmb/VVjSYPjHmDLvcmHFwQ2_qtwPZxM=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/fresh-margarita-cocktail-recipe-759317-step-05-dae71772c4304cf7911489a1c7d219ab.jpg"
                    },
                    new Drink
                    {
                        Name = "Whiskey with Ice",
                        Price = 15.95M,
                        ShortDescription = "The best way to taste whiskey",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.pixabay.com/photo/2018/04/12/14/47/whisky-3313592__340.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2014/04/05/11/20/whiskey-315178__340.jpg"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 15.95M,
                        ShortDescription = "A German digestif made with 56 herbs",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn.pixabay.com/photo/2019/02/02/14/36/food-3970692__340.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2014/04/24/16/43/yeager-331510__340.jpg"
                    },
                    new Drink
                    {
                        Name = "Champagne",
                        Price = 15.95M,
                        ShortDescription = "That is how sparkling wine can be called",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/celebration-toast-with-champagne-picture-id1178741587?b=1&k=6&m=1178741587&s=170667a&w=0&h=g47EVMMhyHZ8VUPI9iDiqipyHxk0PipyuD4xrRec4fo=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2019/12/26/09/13/glasses-4720011__340.jpg"
                    },
                    new Drink
                    {
                        Name = "Piña colada ",
                        Price = 15.95M,
                        ShortDescription = "A sweet cocktail made with rum.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/two-glasses-of-pineapple-colada-at-the-edge-of-a-pool-picture-id1179055554?b=1&k=6&m=1179055554&s=170667a&w=0&h=W6bYSSKGt_R4sNx3OC-Xdi5IBwTnbFyZkOtaWH3q1BU=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/pina-colada-with-pineapple-slices-on-wooden-table-picture-id462523193?b=1&k=6&m=462523193&s=170667a&w=0&h=4viWi1PGoKfLLY7L99rVZgUgxBZTk3AwYkQ5dYHT8jA="
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 15.95M,
                        ShortDescription = "A cocktail made with vodka ",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/white-russian-cocktail-picture-id465501484?b=1&k=6&m=465501484&s=170667a&w=0&h=K-k6DttF7IMr29yrLPDNry3nhqy6kBRuY9vcTp4iPXc=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/white-russian-cocktail-picture-id467235582?b=1&k=6&m=467235582&s=170667a&w=0&h=mVR1y68Hw5C1APZqoGbAQFh5ijJHCQPv1zyDVD9K__c="
                    },
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 15.95M,
                        ShortDescription = "Aa mixed drink made with tequila.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/tasty-long-island-drink-with-ice-cube-and-alcohol-picture-id683552796?b=1&k=6&m=683552796&s=170667a&w=0&h=UEmbnCTqKARUpwSBmC5PgKBiefQevXQ-lBxNiOyyDvU=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/cocktail-cuba-libre-or-long-island-iced-tea-with-rom-cola-lime-and-picture-id1194647305?b=1&k=6&m=1194647305&s=170667a&w=0&h=jV_l-HbFhvUJlku4CK_o3Yyj9wfTIb2JAkVBAcy98Pk="
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 15.95M,
                        ShortDescription = "A distilled beverage with water and ethanol.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/refreshing-cold-summer-cocktail-with-soda-water-lemon-and-ice-cubes-picture-id1209087745?b=1&k=6&m=1209087745&s=170667a&w=0&h=qEdcPfdqQptqkUsGaf3aL6ESh6q6xmat5IpYxNbgtFk=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/vodka-in-shot-glasses-on-rustic-wood-background-picture-id909199856?b=1&k=6&m=909199856&s=170667a&w=0&h=2Kn1v2wwVktS5b5Bv8diO6JbuGiVYhNSlCm-M0nwtcg="
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 15.95M,
                        ShortDescription = "Made with gin and tonic water poured over ice.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/three-gin-tonic-cocktails-with-strawberries-lime-and-blueberries-picture-id1203966120?b=1&k=6&m=1203966120&s=170667a&w=0&h=9je3RjWIaLFCGgrIEkntKMUCkOfyPiyVIZG4oXzbr1Y=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/alcohol-drink-with-lemon-juniper-branch-and-ice-on-rustic-wooden-picture-id1276587534?b=1&k=6&m=1276587534&s=170667a&w=0&h=jFnx0E4wkbpcFXr7sa8sKyZczYzNDqAlnG8Zcxs5K-w="
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.95M,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/cosmopolitan-martini-picture-id469525437?b=1&k=6&m=469525437&s=170667a&w=0&h=D05FFKNfRkxWs-vvgIpbwEt45kqJHcmoapkOhLcRKq8=",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/an-alcoholic-cosmopolitan-cocktail-is-on-the-bar-space-for-text-picture-id890771104?b=1&k=6&m=890771104&s=170667a&w=0&h=MPi8Qg4eO0RZS8GGAbgY_WRKkl7a8GVLCTQiJC9-Quo="
                    },
                    new Drink
                    {
                        Name = "Tea ",
                        Price = 12.95M,
                        ShortDescription = "Made by leaves of the tea plant in hot water.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/ginger-turmeric-cup-of-tea-on-wooden-board-with-ingredients-picture-id1270049248?b=1&k=6&m=1270049248&s=170667a&w=0&h=4lP_HYRLkayUaIiywjQQBDsdvx6DDoIhhspu496-7yU=",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/steaming-hot-tea-in-a-glass-cup-is-standing-outside-on-a-cold-winter-picture-id924826108?b=1&k=6&m=924826108&s=170667a&w=0&h=T4SwDBmkh6UFTBqefMHFK36HPgjZgijzpiO2Kj2_Q-w="
                    },
                    new Drink
                    {
                        Name = "Water ",
                        Price = 12.95M,
                        ShortDescription = " It makes up more than half of your body weight ",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/water-pouring-into-glass-picture-id1183424538?b=1&k=6&m=1183424538&s=170667a&w=0&h=WQLeMuN7AeHQzlj_zaG_KRRg8oikIEi7d4kosYP5KV0=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/filling-up-a-glass-with-drinking-water-from-kitchen-tap-picture-id1204637747?b=1&k=6&m=1204637747&s=170667a&w=0&h=a8uf5wPELMZSapC3Ey8DhoENJEevqBMvAUQ6rSy6SZY="
                    },
                    new Drink
                    {
                        Name = "Coffee ",
                        Price = 12.95M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/cup-of-espresso-with-coffee-beans-picture-id1177900376?b=1&k=6&m=1177900376&s=170667a&w=0&h=A09IfobuUGwpI5uZmHpbrYORykSREdGIM6bYaD17Xv4=",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/cup-of-espresso-with-coffee-beans-picture-id1177900338?b=1&k=6&m=1177900338&s=170667a&w=0&h=Lo7TWEv7sk9u6z6LvSSCahneASDVqzc_ExsEj5umAJ8="
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 12.95M,
                        ShortDescription = "A very refreshing Russian beverage",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Mint_bread_kvas.jpg/250px-Mint_bread_kvas.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://i1.wp.com/practicalselfreliance.com/wp-content/uploads/2019/04/homemade-kvass-4.jpg?resize=600%2C400&ssl=1"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription =
                            "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl =
                            "https://media.istockphoto.com/photos/fresh-picture-id1164349316?b=1&k=6&m=1164349316&s=170667a&w=0&h=eY3CYfT5bI-zjmM1Nzm3fd4oJPBiwzB1_EUSPhN6AO0=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl =
                            "https://media.istockphoto.com/photos/glass-of-orange-juice-picture-id866921274?b=1&k=6&m=866921274&s=170667a&w=0&h=wzWvr_hkdG6E8GuGij2IIgNTyTbk9RWyWla8XtwIOf4="
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category {CategoryName = "Alcoholic", Description = "All alcoholic drinks"},
                        new Category {CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"}
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Abstract;
using DrinkAndGo.DataAccess.Entity;

namespace DrinkAndGo.DataAccess.Concrete
{
    public class DrinkDal:IDrinkRepository
    {
        private readonly List<Drink> _drinks;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkDal(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _drinks=new List<Drink>
           {
                    new Drink {
                        Name = "Beer",
                        Price = 7.95M, ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://cdn-b.william-reed.com/var/wrbm_gb_hospitality/storage/images/publications/hospitality/bighospitality.co.uk/article/2018/04/26/beer-quiz-25-questions-to-test-your-knowledge/2807204-1-eng-GB/Beer-quiz-25-questions-to-test-your-knowledge_wrbm_large.jpg"
                    },
                    new Drink {
                        Name = "Rum & Coke",
                        Price = 12.95M, ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/rumCokeL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.artofdrink.com/wp-content/uploads/2016/02/rum-coke-coca-cola-750x500.jpg"
                    },
                    new Drink {
                        Name = "Tequila ",
                        Price = 12.95M, ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/tequilaL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdn-a.william-reed.com/var/wrbm_gb_food_pharma/storage/images/publications/food-beverage-nutrition/foodnavigator-asia.com/headlines/markets/tequila-power-forget-the-slammers-aussies-could-use-agave-plant-for-eco-fuel-and-hand-sanitiser/10865503-1-eng-GB/Tequila-power-Forget-the-slammers-Aussies-could-use-agave-plant-for-eco-fuel-and-hand-sanitiser_wrbm_large.jpg"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://www.newfoodmagazine.com/wp-content/uploads/featured-image_for-web-11-750x500.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.newfoodmagazine.com/wp-content/uploads/featured-image_for-web-11-750x500.jpg"
                    }
                };
        }

        public IEnumerable<Drink> Drinks => _drinks;

        public IEnumerable<Drink> PreferredDrinks
        {
            get
            {
                return _drinks.Where(d => d.IsPreferredDrink == true).ToList();
            }
        }

        public Drink GetDrinkById(int drinkId)
        {
            return _drinks.FirstOrDefault(d => d.DrinkId == drinkId);
        }
    }
}



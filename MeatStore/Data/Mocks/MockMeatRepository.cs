using System;
using System.Collections.Generic;
using System.Linq;
using MeatStore.Data.Interfaces;
using MeatStore.Data.Models;

namespace MeatStore.Data.Mocks
{
    public class MockMeatRepository : IMeatRepository
    {
        
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Meat> Meats
        {
            get
            {
                return new List<Meat>
                {
                    new Meat {
                        Name = "beef",
                        Price = 7.95M, ShortDescription = "The most widely consumed Meat",
                        LongDescription ="Beef is the culinary name for meat from cattle," +
                        " particularly skeletal muscle. Humans have been eating beef since prehistoric times." +
                        " Beef is a source of high-quality protein and nutrients.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = 10,
                        IsPreferredMeat = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Meat {
                        Name = "GroundBeef",
                        Price = 12.95M, ShortDescription = "It is used in many recipes including hamburgers and spaghetti Bolognese.",
                        LongDescription = "Ground beef, minced beef or beef mince is beef that has been finely chopped with a knife or a meat grinder" +
                                          " (American English) or mincing machine (British English)." +
                                          " It is used in many recipes including hamburgers and spaghetti Bolognese.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/rumCokeL.jpg",
                        InStock = 10,
                        IsPreferredMeat = false,
                        ImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
                    },
                    new Meat {
                        Name = "Pork belly",
                        Price = 12.95M, ShortDescription = "The pork belly is one of the most tasty part of the pork.",
                        LongDescription ="Pork belly is a boneless cut of fatty meat from the belly of a pig. Pork belly is particularly popular " +
                                         "in Hispanic, Chinese, Korean and Philippine cuisine.",
                        Category =  _categoryRepository.Categories.Last(),
                        ImageUrl = "http://imgh.us/tequilaL.jpg",
                        InStock = 10,
                        IsPreferredMeat = false,
                        ImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
                    },
                    new Meat
                    {
                        Name = "Pork chop ",
                        Price = 12.95M,
                        ShortDescription = "pork chops are the most commonly consumed meat cut from the pork loin.",
                        LongDescription ="A pork chop, like other meat chops, is a loin cut taken perpendicular to the spine of the pig and usually" +
                                         " containing a rib or part of a vertebra. " +
                                         "Pork chops are not processed and are leaner than other cuts of pork. Chops are commonly served as an individual portion.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://imgh.us/juiceL.jpg",
                        InStock = 10,
                        IsPreferredMeat = false,
                        ImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
                    }
                };
            }
            set => throw new NotImplementedException();
        }
        public IEnumerable<Meat> PreferredMeats { get; set; }

        public Meat GetMeatById(int MeatId)
        {
            throw new NotImplementedException();
        }
    }
    
}

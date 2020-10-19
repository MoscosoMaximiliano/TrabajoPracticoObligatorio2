using System.Collections.Generic;

namespace CapaNegocio
{
    public class Products
    {
        public static List<CNItem> GetItems()
        {
            return new List<CNItem>
            {
                new CNItem
                {
                    ID = "RB2019",
                    Name = "Razer Blackwidow 2019",
                    Description = "A powerful keyboard used for be the best on your games",
                    Price = 249.59f
                },
                new CNItem
                {
                    ID = "BWU2017",
                    Name = "BlackWidow Ultimate 2017",
                    Description = "A keyboard",
                    Price = 185.59f
                }
            };
        }
    }
}
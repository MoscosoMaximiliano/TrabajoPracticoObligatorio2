using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class Products
    {
        public static List<CNProduct> GetItems()
        {
            try
            {
                var _CapaDato = CapaDatos.Methods.EF.GetProducts();

                return _CapaDato.Select(x => new CNProduct
                {
                    ID = x.IDProduct,
                    Description = "",
                    Name = x.Name,
                    ImgUrl = x.UrlImage,
                    Price = x.Price,
                    IsOffer = x.IsOffer,
                    IsFeatured = x.IsFeatured
                    
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            
            // return new List<CNItem>
            // {
            //     new CNItem
            //     {
            //         ID = "RP2",
            //         Name = "Razer Blackwidow 2019",
            //         Description = "Powerful gaming phone",
            //         Price = 19.99f,
            //         ImgUrl = "RazerPhone2TemperedGlassProtectorKit.png",
            //         IsOffer = false
            //     },
            //     new CNItem
            //     {
            //         ID = "RKKB",
            //         Name = "Razer Kraken Kitty Black",
            //         Description = "This is a description of the product",
            //         Price = 149.99f,
            //         ImgUrl = "RazerKrakenKitty-Black.png",
            //         IsOffer = false
            //     },
            //     new CNItem
            //     {
            //         ID = "RNUOLE",
            //         Name = "Razer Nari Ultimate Overwatch Lúcio Edition",
            //         Description = "This is a description of the product",
            //         Price = 229.99f,
            //         ImgUrl = "RazerNariUltimate-OverwatchLúcioEdition.png",
            //         IsOffer = false
            //     },
            //     new CNItem
            //     {
            //         ID = "RNU",
            //         Name = "Razer Nari Ultimate",
            //         Description = "This is a description of the product",
            //         Price = 199.99f,
            //         ImgUrl = "RazerNariUltimate.png",
            //         IsOffer = false
            //     },
            //     new CNItem
            //     {
            //         ID = "RGMOLE",
            //         Name = "Razer Goliathus Medium Overwatch Lúcio Edition",
            //         Description = "This is a description of the product",
            //         Price = 29.99f,
            //         ImgUrl = "RazerGoliathusMedium-OverwatchLucioEdition.png",
            //         IsOffer = true
            //     },
            //     new CNItem
            //     {
            //         ID = "RGCEG5",
            //         Name = "Razer Goliathus Chroma Extended Gears 5",
            //         Description = "This is a description of the product",
            //         Price = 79.99f,
            //         ImgUrl = "RazerGoliathusChromaExtendedGears5.png",
            //         IsOffer = true
            //     },
            //     new CNItem
            //     {
            //         ID = "RBQ",
            //         Name = "Razer Basilisk Quartz",
            //         Description = "This is a description of the product",
            //         Price = 69.99f,
            //         ImgUrl = "Razer-Basilisk-Quartz.png",
            //         IsOffer = true
            //     },
            //     new CNItem
            //     {
            //         ID = "RB2019",
            //         Name = "Razer BlackWidow 2019",
            //         Description = "This is a description of the product",
            //         Price = 169.99f,
            //         ImgUrl = "BlackWidow-2019.png",
            //         IsOffer = true
            //     }
            // };
        }

        public static List<CNCategories> GetCategories()
        {
            try
            {
                var capaDato = CapaDatos.Methods.EF.GetCategories();

                return capaDato.Select(x => new CNCategories
                {
                    ID = x.IDCategory,
                    Category = x.Name
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

            // return new List<CNCategories>
            // {
            //     new CNCategories
            //     {
            //         ID = "Notebook",
            //         Category = "Notebook",
            //         SubCategory = {}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Phones",
            //         Category = "Phones",
            //         SubCategory = {}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Mices",
            //         Category = "Mices",
            //         SubCategory = {"Wireless", "Wireless Powered", "Wired", "Mobile"}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Keyboards",
            //         Category = "Keyboards",
            //         SubCategory = {"Keypads", "Optical", "Mechanical", "Mecha-Membrane"}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Headset",
            //         Category = "Headset",
            //         SubCategory = {"Speakers", "Console", "Wired", "Wireless"}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Console",
            //         Category = "Console",
            //         SubCategory = {}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Backpacks",
            //         Category = "Backpacks",
            //         SubCategory = {}
            //     },
            //     new CNCategories
            //     {
            //         ID = "Mouse-Pads",
            //         Category = "Mouse Pads",
            //         SubCategory = {}
            //     }
            // };
        }

        public static List<CNSubCategories> GetSubCategories()
        {
            try
            {
                var capaDato = CapaDatos.Methods.EF.GetSubCategories();

                return capaDato.Select(x => new CNSubCategories
                {
                    
                    ID = x.ID,
                    IdCategory = x.IdCategory,
                    Name = x.Name
                    
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
        
}
}
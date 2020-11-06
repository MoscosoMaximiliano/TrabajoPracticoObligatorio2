using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class CNTPO2
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

        public static void AddQuery(string name, string email, string phone, string message)
        {
            CapaDatos.Methods.EF.SetQuery(name, email, phone, message);
        }
    }
}
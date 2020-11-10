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
                var capaDatos = CapaDatos.Methods.EF.GetSubCategories();

                return capaDatos.Select(x => new CNSubCategories
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

        public static bool AddQuery(string name, string mail, string phone, string message)
        {
            try
            {
                var capaDatos = false;
                
                if (ValidateData(name, mail, phone, message))
                {
                    capaDatos = CapaDatos.Methods.EF.SetQuery(name, mail, phone, message);
                }
                
                return capaDatos;
                
            }
            catch (Exception e)
            {
                return false;
            }
        }

        static bool ValidateData(string name, string mail, string phone, string message)
        {
            if (name == "" && mail == "" && phone == "" && message == "")
                return false;
                
            return true;
        }

        public static string ErrorsValidation(string name, string mail, string phone, string message)
        {
            List<string> errs = new List<string>();
            string finalResult = "";

            if(string.IsNullOrEmpty(name))
                errs.Add("Name field its empty");

            else if(name.Length < 4)
            {
                errs.Add("The name can only contain alphanumeric characters");
                errs.Add("The name its too short");
            }
        

            else if(name.Length > 30)
            {
                errs.Add("The name its too long");
                errs.Add("The name can only contain alphanumeric characters");
            }

            if(string.IsNullOrEmpty(mail))
                errs.Add("Email field its empty");

            if(string.IsNullOrEmpty(phone))
                errs.Add("Business field its empty");

            else if(phone.Length > 20)
            {
                errs.Add("Business message cannot be more than 20 characters");
            }

            if(string.IsNullOrEmpty(message))
                errs.Add("Message field its empty");

            else if(message.Length < 10)
            {
                errs.Add("Message its too short");
            }

            else if(message.Length > 100)
            {
                errs.Add("Message its too long");
            }
            
            for (int index = 0; index < errs.Count; index++) {
                string element = errs[index];

                finalResult += "<li>" + element + "</li>";
            
            }

            return finalResult;
        }
    }
}
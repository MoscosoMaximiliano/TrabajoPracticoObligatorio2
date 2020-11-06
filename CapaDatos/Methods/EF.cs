using CapaDatos.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Methods
{
    public static class EF
    {
        public static List<Categoria> GetCategories()
        {
            try
            {
                using (var context = new Data())
                {
                    return context.Categorias.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<SubCategoria> GetSubCategories()
        {
            try
            {
                using (var context = new Data())
                {
                    return context.SubCategoria.Include("CategoryFrom").ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public static List<Producto> GetProducts()
        {
            try
            {
                using (var context = new Data())
                {
                    return context.Producto.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public static bool SetQuery(string Name, string Mail, string Phone, string Message)
        {
            try
            {
                using (var context = new Data())
                {
                    var query = new Consulta
                    {
                        Name = Name,
                        Mail = Mail,
                        NumberPhone = Phone,
                        Message = Message
                    };

                    context.Consulta.Add(query);

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        
    }
}

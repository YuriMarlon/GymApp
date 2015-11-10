using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GymAppWS
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        public ModelEntityContainer bd = new ModelEntityContainer();
        [WebMethod]
        public int CrearUsuario(String usuario,String clave)
        {
            try {
                usuario obj = new usuario {Usuario = usuario , Clave = clave};              
                bd.usuario.Add(obj);
                bd.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return 0;
            }
            
        }

        [WebMethod]
        public List<usuario> ListarUsuario()
        {
            List<usuario> a=new List<usuario>();

            try
            {
                return bd.usuario.ToList();
            }
            catch (Exception)
            {
                return a;
            }

        }

        [WebMethod]
        public List<usuario> ListarUsuario()
        {
            List<usuario> a = new List<usuario>();

            try
            {
                return bd.usuario.ToList();
            }
            catch (Exception)
            {
                return a;
            }

        }

    }
}

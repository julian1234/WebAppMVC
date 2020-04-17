using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class VENDEDOR_WEB_APIController : ApiController
    {

        public DB_A56C50_admin759Entities db = new DB_A56C50_admin759Entities();

        // GET: api/VENDEDOR_WEB_API

        public IEnumerable<VENDEDOR> Get()
        {

            List<VENDEDOR> li = new List<VENDEDOR>();

            var result = db.VENDEDOR.Where(x => x.CODIGO > 0).ToList();
           
            foreach (var item in result)
            {

                VENDEDOR DATA = new VENDEDOR();

                DATA.CODIGO = item.CODIGO;
                DATA.NOMBRE = item.NOMBRE;
                DATA.APELLIDO = item.APELLIDO;
                DATA.NUMERO_IDENTIFICACION = item.NUMERO_IDENTIFICACION;
                DATA.CODIGO_CIUDAD = item.CODIGO_CIUDAD;

                li.Add(DATA);

            }
           
            return li;
        }


        // GET: api/VENDEDOR_WEB_API/5
        public VENDEDOR Get(int? id)
        {

          
            VENDEDOR DATA = new VENDEDOR();


            if (id == null)
            {
                return DATA;
            }

            else
            {
                var result = db.VENDEDOR.Where(x => x.CODIGO > 0).ToList();

                foreach (var item in result)
                {
                   

                    if (item.CODIGO == id)
                    {
                        DATA.CODIGO = item.CODIGO;
                        DATA.NOMBRE = item.NOMBRE;
                        DATA.APELLIDO = item.APELLIDO;
                        DATA.NUMERO_IDENTIFICACION = item.NUMERO_IDENTIFICACION;
                        DATA.CODIGO_CIUDAD = item.CODIGO_CIUDAD;

                    }

                }

                return DATA;

            }
           

        }

        // POST: api/VENDEDOR_WEB_API
        public VENDEDOR Post([FromBody]VENDEDOR value)
        {
            
            db.VENDEDOR.Add(value);
            db.SaveChanges();


            return value;

        }

        // PUT: api/VENDEDOR_WEB_API/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VENDEDOR_WEB_API/5
        public void Delete(int id)
        {
        }
    }
}

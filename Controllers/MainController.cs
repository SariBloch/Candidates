using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeesApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MainController : ApiController
    {
   


        [HttpGet]
        public IHttpActionResult GetData()
        {
            try
            {
                string data = "{\"Candidates\":[{\"id\":\"1\",\"name\":\"Moshe\",\"beginYear\":\"2020\",\"lastUpdateDate\":\"2022-11-03\",\"languages\":[1,3]},{\"id\":\"20\",\"name\":\"Avi\",\"beginYear\":\"2020\",\"lastUpdateDate\":\"2021-09-27\",\"languages\":[3]},{\"id\":\"300\",\"name\":\"Gila\",\"beginYear\":\"\",\"lastUpdateDate\":\"2023-01-01\",\"languages\":[2,4,7]},{\"id\":\"300\",\"name\":\"Rina\",\"beginYear\":\"2019\",\"lastUpdateDate\":\"2021-05-17\",\"languages\":[2,3,6]}],\"Languages\":[{\"id\":1,\"name\":\"Java\"},{\"id\":2,\"name\":\".NET\"},{\"id\":3,\"name\":\"NodeJS\"},{\"id\":4,\"name\":\"AdvancedVanillaJS\"},{\"id\":5,\"name\":\"React\"},{\"id\":6,\"name\":\"Angular\"},{\"id\":7,\"name\":\"Kotlin\"},{\"id\":8,\"name\":\"Dart\"},{\"id\":9,\"name\":\"Flutter\"}]}";
                Root root = JsonSerializer.Deserialize<Root>(data);
                return Ok(data);
                //return root;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }


}

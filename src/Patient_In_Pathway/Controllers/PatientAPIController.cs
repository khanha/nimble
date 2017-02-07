using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Patient_In_Pathway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_In_Pathway.Controllers
{
    [Route("api/Patient")]
    public class PatientAPIController : Controller
    {
        Models.DataAccess objds;

        public PatientAPIController(DataAccess d)
        {
            //Model.DataAccessPatient d = null;
            objds = d;
        }

        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return objds.GetPatients();
        }
        [HttpGet("{id:length(24)}")]
        [HttpGet("{LastName}")]
        public IActionResult Get(string LastName)
        {
            var patient = objds.GetPatient(LastName);
            if (patient == null)
            {
                return NotFound();
            }
            return new ObjectResult(patient);
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var patient = objds.GetPatient(id);
        //    if (patient == null)
        //    {

        //        return NotFound();
        //    }
        //    return new ObjectResult(patient);
        //}

        [HttpGet("/category/{category}")]
        public IActionResult Get(string category, int id)
        {
            id = 0;
            var patient = objds.GetPatient(category, id);
            if (patient == null)
            {

                return NotFound();
            }
            return new ObjectResult(patient);
        }

        [HttpPost]
        //public IActionResult Post([FromBody]JsonToken jsonbody)
        public IActionResult Post([FromBody]Patient model)
        {

            //string jsonString = model.ToString() ;
            //Console.WriteLine(jsonString);


            //Patient pt = new Patient();
            ////pt.LastName = jsonString;
            // try
            //{
            //     JsonConvert.PopulateObject(jsonString, pt);
            // }
            // catch (Exception e) { }

            //var patient = objds.Create(new Model.Patient() { FirstName="Hashir", LastName="Sultan"});
            var patient = objds.Create(model);
            //Patient patient = null;
            if (patient == null)
            {
                return NoContent();

            }
            return new OkObjectResult(patient);

        }


        //[HttpPut("{id:length(24)}")]
        //public IActionResult Put(string id, [FromBody]Patient p)
        //{
        //    var recId = new ObjectId(id); 
        //    var patient = objds.GetPatient(recId);
        //    if (patient == null)
        //    {
        //        return NotFound();
        //    }

        //    objds.Update(recId, p);
        //    return new OkResult();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(string id)
        //{
        //    var patient = objds.GetProduct(new ObjectId(id));
        //    if (patient == null)
        //    {
        //        return NotFound();
        //    }

        //    objds.Remove(Task<Product>patient);
        //    return new OkResult();
        //}
    }
    }

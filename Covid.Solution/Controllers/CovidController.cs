using Covid.Entities.Patient;
using Covid.Services.Patients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid.Solution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        readonly IPatientService _patientService;
        public CovidController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            try { 
                return _patientService.getPatients();
            }
            catch (Exception ex) { throw; }
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try { 
                return Ok(_patientService.getPatients(id));
            }
            catch (Exception ex) { throw; }
}

        [HttpPost]
        public IActionResult Post([FromBody] Patient data)
        {
            try { 
                return Ok(_patientService.AddPatient(data));
            }
            catch (Exception ex) { throw; }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Patient value)
        {
            try { 
                return Ok(_patientService.UpdatePatient(id,value));
            }
            catch (Exception ex) { throw; }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try { 
                return Ok(_patientService.DeletePatient(id));
            }
            catch (Exception ex) { throw; }
        }

    }
}

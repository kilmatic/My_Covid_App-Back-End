using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_Covid_App.Entities;
using My_Covid_App.Infrastructure;
using My_Covid_App.Models;
using My_Covid_App.Models.DoctorsModel;

namespace My_Covid_App.Controllers
{
    [Authorize(Roles = "Doctor")]
    public class DoctorsController : ApiController
    {
        private readonly CovidDBContext data;

        public DoctorsController(CovidDBContext data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(DoctorCreateRequestModel model)
        {
            var userId = this.User.GetId();

            var doctor = new Doctor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Identification = model.Identification,
                EmployeeNumber = model.EmployeeNumber,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                UserId = userId,
            };

            this.data.Add(doctor);

            await this.data.SaveChangesAsync();

            return Created(nameof(this.Created), doctor.Id);
        }

        //public async Task<ActionResult> Update()
    }
}

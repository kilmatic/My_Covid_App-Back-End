using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_Covid_App.Entities;
using My_Covid_App.Infrastructure;
using My_Covid_App.Models;
using My_Covid_App.Models.NursesModel;

namespace My_Covid_App.Controllers
{
    public class NursesController : ApiController
    {
        private readonly CovidDBContext data;

        public NursesController(CovidDBContext data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(NurseCreateRequestModel model)
        {
            var userId = this.User.GetId();

            var nurse = new Nurse
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Identification = model.Identification,
                EmployeeNumber = model.EmployeeNumber,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                UserId = userId,
            };

            this.data.Add(nurse);

            await this.data.SaveChangesAsync();

            return Created(nameof(this.Created), nurse.Id);
        }
    }
}

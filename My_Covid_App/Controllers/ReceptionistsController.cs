using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_Covid_App.Entities;
using My_Covid_App.Infrastructure;
using My_Covid_App.Models;
using My_Covid_App.Models.ReceptionistsModel;

namespace My_Covid_App.Controllers
{
    public class ReceptionistsController : ApiController
    {
        private readonly CovidDBContext data;

        public ReceptionistsController(CovidDBContext data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(ReceptionistCreateRequestModel model)
        {
            var userId = this.User.GetId();

            var receptionist = new Receptionist
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Identification = model.Identification,
                EmployeeNumber = model.EmployeeNumber,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                UserId = userId,
            };

            this.data.Add(receptionist);

            await this.data.SaveChangesAsync();

            return Created(nameof(this.Create), receptionist.Id);
        }
    }
}

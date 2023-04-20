using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_Covid_App.Entities;
using My_Covid_App.Infrastructure;
using My_Covid_App.Models;
using My_Covid_App.Models.PharmacistsModel;

namespace My_Covid_App.Controllers
{
    [Authorize(Roles = "Pharmacist")]
    public class PharmacistsController : ApiController
    {
        private readonly CovidDBContext data;

        public PharmacistsController(CovidDBContext data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(PharmacistCreateRequestModel model)
        {
            var userId = this.User.GetId();

            var pharmacist = new Pharmacist
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Identification = model.Identification,
                EmployeeNumber = model.EmployeeNumber,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                UserId = userId,
            };

            this.data.Add(pharmacist);

            await this.data.SaveChangesAsync();

            return Created(nameof(this.Created), pharmacist.Id);
        }
    }
}

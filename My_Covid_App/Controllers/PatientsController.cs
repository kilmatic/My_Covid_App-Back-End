﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_Covid_App.Entities;
using My_Covid_App.Models;
using My_Covid_App.Models.PatientsModel;
using System.Security.Claims;

namespace My_Covid_App.Controllers
{
    public class PatientsController : ApiController
    {
        private readonly CovidDBContext data;

        public PatientsController(CovidDBContext data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(PatientCreateRequestModel model)
        {
            var userId = this.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.NameIdentifier)?.Value;

            var patient = new Patients
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Identification = model.Identification,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                NextOfKeen = model.NextOfKeen,
                NextOfKeenPhoneNumber = model.NextOfKeenPhoneNumber,
                UserId = userId,
            };

            this.data.Add(patient);

            await this.data.SaveChangesAsync();

            return Created(nameof(this.Create), patient.Id);
        }
    }
}

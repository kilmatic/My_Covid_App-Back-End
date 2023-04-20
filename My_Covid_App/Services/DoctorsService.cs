using My_Covid_App.Entities;
using My_Covid_App.IService;
using My_Covid_App.Models;

namespace My_Covid_App.Services
{
    public class DoctorsService : IAccountService<Doctor>
    {
        private readonly CovidDBContext data;

        public DoctorsService(CovidDBContext data)
        {
            this.data = data;
        }

        public Doctor Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Delete(int id)
        {
            var doctor = data.Doctors.Find(data); 
        }
    }
}

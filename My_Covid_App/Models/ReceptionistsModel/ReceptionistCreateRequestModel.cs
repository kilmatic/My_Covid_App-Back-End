namespace My_Covid_App.Models.ReceptionistsModel
{
    public class ReceptionistCreateRequestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Identification { get; set; }

        public int EmployeeNumber { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}

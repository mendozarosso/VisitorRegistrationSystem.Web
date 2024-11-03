

namespace VisitorRegistrationSystem.Web.Data.Models{
    public class Visitor {
        public int Id {get; set;}



    

    public string Phone {get; set ;} = string.Empty;

    public string FirstName {get; set;} = string.Empty;

    public string LastName {get; set;} = string.Empty;

    public string Email {get; set;} = string.Empty;

    public DateTime RegistrationDate {get; set;} = DateTime.Now;
}

}
namespace HRBirthday.Entity
{
    public class Staff : BaseEnitity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
    }
}

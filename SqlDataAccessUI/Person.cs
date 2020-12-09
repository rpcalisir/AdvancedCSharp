
namespace SqlDataAccessUI
{
    /// <summary>
    /// Property names must be same which defined in sql database
    /// </summary>
    public class Person
    {
        public int PeopleId { get; set; }
        public string FirstName { get; set; }        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get 
            {
                return $"{FirstName} {LastName} ({EmailAddress}) ({PhoneNumber})"; 
            }
        }

    }
}

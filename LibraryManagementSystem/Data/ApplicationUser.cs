using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Data
{
    public class ApplicationUser:IdentityUser
    {
        private string firstname;
        private string lastname;
        private string phone;
        private bool terms;
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public bool Terms
        {
            get
            {
                return terms;
            }
            set
            {
                terms = value;
            }
        }
    }
}

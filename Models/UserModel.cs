using Microsoft.EntityFrameworkCore.Diagnostics;

namespace WebApplication2.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { set; private get; }
        public string PhoneNumber { get; set; }
        public int EmailConfirmed { get; set; }
        public string PasswordConfirm { private get; set; }
        public int PhoneNumberConfirmed { get; set; }
        public int AccountStatus { get; set; }

        /**
         * Function should do the following:
         *  1. validate that all imputs are acceptable
         *  2. process the save to the data source in this case DB
         *  This should be used for Create and Update methods
         */
        public void Save()
        {
            //
        }

        /**
         * Function should show if there are errors on the data being desired to save.
         */
        private void ValidateData()
        {
            //
        }

        /**
         * Fetches a single user class from the data source or null | empty if not found?
         */
        public UserModel Fetch(int id)
        {
            //
            return this;
        }


        /**
         * Fetches a list of users from the data source
         */
        public List<UserModel> FetchAll()
        {
            return new List<UserModel>();
        }

        /**
         * Function to process a delete action from the data source
         */
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}

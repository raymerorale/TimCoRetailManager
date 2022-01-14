using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

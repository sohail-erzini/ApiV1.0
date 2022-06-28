using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.client
{
    internal class UserDto
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string fullName { get; set; }

        public string email { get; set; }

        public string tel { get; set; }

        public string adresse { get; set; }

        public Status status { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime? updatedAt { get; set; }
    }

    public enum Status
    {
        active, blocked
    }

}

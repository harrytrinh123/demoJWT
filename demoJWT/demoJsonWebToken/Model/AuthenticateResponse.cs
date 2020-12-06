using demoJsonWebToken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoJsonWebToken.Model
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            firstName = user.firstName;
            lastName = user.lastName;
            userName = user.userName;
            this.token = token;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        // Stick to "Id" as entity framework
        public int Id { get; set; }
        //ASP.net core indentity uses "UserName" instead "Username"
        public string UserName { get; set; }
        
    }
}
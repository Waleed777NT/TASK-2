using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    public class Users
    {
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Phone_Number { get; set; }

        public Users() { }
        public Users(string fname, string lname, string phnum)
        {
            this.Phone_Number = phnum;
            this.First_Name = fname;
            this.Last_Name = lname;
        }
    }
}

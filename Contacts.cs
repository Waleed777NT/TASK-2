using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    public class Contacts
    {

        public Dictionary<string, Users> users = new Dictionary<string, Users>();

        public Contacts()
        {
            users.Add("01062767571", new Users("fahmy", "aboshabana", "01062767571"));
            users.Add("01559967571", new Users("fahmy", "aboshaban#2", "01559967571"));
            users.Add("01019389953", new Users("waleed", "tatntawy", "01019389953"));
            users.Add("01004746807", new Users("nashaat", "tantawy", "01004746807"));
            users.Add("01094493819", new Users("moaz", "mohsen", "01094493819"));
            users.Add("01099300572", new Users("HOS", "THE BOS", "01099300572"));
            users.Add("01091251806", new Users("yousef", "oraby", "01091251806"));
            users.Add("01557076117", new Users("karim", "Gom3aa", "01557076117"));
            users.Add("01066502150", new Users("ahmed", "fahmy", "01066502150"));
            users.Add("01000111252", new Users("Gana", "Rashid", "01000111252"));
            users.Add("01252147896", new Users("Mairem", "Elnagar", "01252147896"));
            users.Add("01124785692", new Users("Noor", "Ashoor", "01124785692"));
            users.Add("01025874125", new Users("Osam", "Elsaid", "01025874125"));
            users.Add("01023658451", new Users("Abdoo", "Waleed", "01023658451"));
            users.Add("01235485559", new Users("Reem", "Elkellany", "01235485559"));
            users.Add("01025584455", new Users("Messi", "3my", "01025584455"));
            users.Add("01025584155", new Users("Metwally", "Elkalliobi", "01025584155"));
            users.Add("01002587412", new Users("Farouk", "Mohammed", "01002587412"));
            users.Add("01254885562", new Users("Pedri", "Gonzalliz", "01254885562"));
            users.Add("01124484698", new Users("Leva", "Elharaqe", "01065562301"));
        }
        public void Add_Contact()
        {
            Console.Clear();
            string input = "00000000000";
            Console.Write("Enter Number To Add : ");
            input = Console.ReadLine() ?? "01062767571";
            while (users.ContainsKey(input))
            {
                Console.Write("\nContact Already Exists\nEnter Number Again : ");
                input = Console.ReadLine() ?? "";
            }
            string fname, lname;
            Console.Write("First Name : ");
            fname = Console.ReadLine() ?? "unknown";
            Console.Write("Last Name : ");
            lname = Console.ReadLine() ?? "unknown";

            users.Add(input, new Users(fname, lname, input));
            Console.WriteLine("Contact Added Successfully");
            Closing();
        }
        public void Edit_Contact()
        {
            Console.Clear();
            Console.Write("Enter Number Of Contact To Edit :");
            string input = Console.ReadLine() ?? "00000000000";
            while (!users.ContainsKey(input))
            {
                Console.WriteLine("Contact Not Found");
                Console.Write("Enter Existing Contact Number : ");
                input = Console.ReadLine() ?? "00000000000";
            }
            string fname, lname;
            Console.Write("New First Name : ");
            fname = Console.ReadLine() ?? "unknown";
            Console.Write("New Last Name : ");
            lname = Console.ReadLine() ?? "unknown";
            var user = users[input];
            user.First_Name = fname;
            user.Last_Name = lname;
            Console.WriteLine("Contact Editid Successfully");
            Closing();
        }
        public void Delete_Contact()
        {
            Console.Clear();
            Console.Write("Enter Number Of Contact To Delete :");
            string input = Console.ReadLine() ?? "00000000000";
            while (!users.ContainsKey(input))
            {
                Console.WriteLine("Contact Not Found");
                Console.Write("Enter Existing Contact Number : ");
            }
            users.Remove(input);
            Console.WriteLine("Contact Removed Successfully");
            Closing();
        }
        public void Disply_Contacts()
        {
            Console.Clear();
            Console.WriteLine("Displaying Contacts...");

            foreach (var user in users.Values)
            {
                Console.WriteLine($"Name : {user.First_Name} {user.Last_Name} ,Phone Number {user.Phone_Number} ");
            }
            Closing();
        }
        public void Closing()
        {

            Console.WriteLine("Do You Want To Make Any Operations ");
            string input = Console.ReadLine() ?? "n";
            while (!(input == "N" || input == "n") && (!(input == "Y" || input == "y")))
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Choose Either [ Y--N ]");
                input = Console.ReadLine() ?? "n";
            }
            if (input == "y" || input == "Y")
                Start();
            else
                return;

        }
        public static void Start()
        {
            Console.Clear();

            Console.WriteLine("What Do You Want To DO : ");
            Console.Write("\n1--> Add Contact\n2--> Edit Contact\n3--> Delete Contact\n4--> Show All Contacts\n5--> Exit\n\nInput: ");
            int input = -1;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 || input > 5))
            {
                Console.Write("Invalid Input \nEnter Number Between [1 -> 5] : ");
            }
            var operation = new Contacts();

            if (input == 1)
            {
                operation.Add_Contact();
            }
            else if (input == 2)
            {
                operation.Edit_Contact();
            }
            else if (input == 3)
            {
                operation.Delete_Contact();
            }
            else if (input == 4)
            {
                operation.Disply_Contacts();
            }
            else
            {
                Console.WriteLine("Thank You\n");
                return;
            }
        }
    }
}

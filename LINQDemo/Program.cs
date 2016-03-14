using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {

        public class User
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        static void Main(string[] args)
        {

            //// demo list object
            List<User> users = new List<User>();
            users.Add(new User() { ID = 1, FirstName = "FirstName A", LastName = "LastName a" });
            users.Add(new User() { ID = 2, FirstName = "FirstName B", LastName = "LastName b" });
            users.Add(new User() { ID = 3, FirstName = "FirstName C", LastName = "LastName c" });
            users.Add(new User() { ID = 4, FirstName = "FirstName D", LastName = "LastName d" });
            users.Add(new User() { ID = 5, FirstName = "FirstName E", LastName = "LastName e" });

            IEnumerable<User> selectedUsers =
                from u in users
                where u.ID > 3
                orderby u.FirstName descending
                select u;

            foreach (User usr in selectedUsers)
            {
                Console.WriteLine( usr.ID + "  " + usr.FirstName + "  " + usr.LastName + "  ");
            }
            
            /*

            //// demo list string
            List < string > names = new List<string>();
            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 2");
            names.Add("Name 5");
            names.Add("Name 5555555555555");

            IEnumerable<string> selectedNames = 
                from sn in names
                where sn.Length > 1 //&& sn.Length < 50 
                select sn;

            foreach (string sn in selectedNames)
            {
                Console.WriteLine(sn);
            }

            //// demo list int

            List<int> names1 = new List<int>();
            names1.Add(12);
            names1.Add(1200);
            names1.Add(1245);
            names1.Add(142);
            names1.Add(112);

            IEnumerable<int> selectedNames1 =
                from sn in names1
                where sn > 30 //&& sn.Length < 50 
                select sn;

            foreach (int sn in selectedNames1)
            {
                Console.WriteLine(sn);
            }
            */
            Console.ReadKey();

        }
    }
}

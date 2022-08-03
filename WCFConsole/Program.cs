using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsWcfToDb1.ServiceReference1;

namespace WCFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client service = new Service1Client();
         
            UI();
            Console.ReadLine();

        }


        public static void UI()
        {
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Choose one option:");
                Console.WriteLine("1 GET ALL PERSON");
                Console.WriteLine("2 DELETE PERSON");
                Console.WriteLine("3 INSERT PERSON");
                Console.WriteLine("4 UPDATE PERSON");
                
                var k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        GetAllPerson();
                        break;
                    case "2":
                        DeletePerson();
                        break;
                    case "3":
                        InsertPerson();
                        break;
                    case "4":
                        UpdatePerson();
                        break;
                    case "5":
                       
                        break;
                    default:
                        break;
                }
            }

        }


        private static void GetAllPerson()
        {
            List<Person> personL = new List<Person>();
            Service1Client service = new Service1Client();            
            var Res = service.GetAllPersons();
            List<string> GOL = Res.Select(x => x.Name).OfType<string>().ToList();
            var res = string.Join(Environment.NewLine, GOL);
            Console.WriteLine(res);

        }


        private static void DeletePerson()
        {
            Person p = new Person()
            {
                
                Id = Convert.ToInt32(Console.ReadLine()),

            };
            Service1Client service = new Service1Client();
            if (service.DeletePerson(p) == 1)
            {
                Console.WriteLine("DELETE OK");
            }

        }

        private static void InsertPerson()
        {
            Person p = new Person();
            p.Id = Convert.ToInt32(Console.ReadLine());
            p.Name = Console.ReadLine();
            p.Age = Convert.ToInt32(Console.ReadLine());

            Service1Client service = new Service1Client();
            if (service.InsertPerson(p) == 1)
            {
               Console.WriteLine("Person Inserted OK");
            }

        }

        private static void UpdatePerson()
        {
            Person p = new Person()
            {

                Id = Convert.ToInt32(Console.ReadLine()),
                Name = Console.ReadLine(),
                Age = Convert.ToInt32(Console.ReadLine())
            };

            Service1Client service = new Service1Client();
            if (service.UpdatePerson(p) == 1)
            {
                Console.WriteLine("UPDATE OK");
            }

        }

        

    }
}

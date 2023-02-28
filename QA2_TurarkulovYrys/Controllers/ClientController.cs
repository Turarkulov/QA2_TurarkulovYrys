using QA2_TurarkulovYrys.DataBase;
using QA2_TurarkulovYrys.Entities;

namespace QA2_TurarkulovYrys.Controllers
{
    public static class ClientController
    {
        public static void AddClient()
        {
            Console.WriteLine("Enter client's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter client's second name:");
            string secondName = Console.ReadLine();
            Console.WriteLine("Enter client's phone number:");
            string phoneNum = Console.ReadLine();

            Client newClient = new Client
            {
                FirstName = firstName,
                SecondName = secondName,
                PhoneNum = phoneNum,
                DateAdd = DateTime.Now
            };

            using (var db = new AppDbContext())
            {

                db.Clients.Add(newClient);
                db.SaveChanges();
            }

            Console.WriteLine("Client added successfully!");
        }

        public static void EditClient()
        {

        }
        public static void DeleteClient()
        {

        }
        public static void Show()
        {

        }
       
    }
}


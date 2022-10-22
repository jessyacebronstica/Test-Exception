using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (itsdbEntities db = new itsdbEntities())
                {
                    //lambda
                    List<club> cList = db.clubs.ToList();

                    club c = new club();


                    c.name = "Club 1";
                    c.description = "Club 1 Description";
                    c.image = String.Empty;
                    c.date_created = DateTime.Now;
                    c.date_update = DateTime.Now;
                    c.created_by = "JET";
                    c.updated_by = "JET";
                    c.is_active = true;
                    c.regional_id = 1;

                    db.clubs.Add(c);
                    db.SaveChanges();

                }
            }
            catch (Exception e) {
                Console.WriteLine("The server is not available as of the moment. Please try again later.");
            }
            Console.ReadKey();
            
        }


    }
}

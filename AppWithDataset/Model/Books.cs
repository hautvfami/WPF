using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithDataset.Model
{
    static class Books
    {
        private static Entities db = new Entities();

        public static List<BOOK> getAllUsers(){
            return db.BOOKS.OrderBy(x => x.ID).ToList();
        }

        public static void handleInsert(BOOK a)
        {
            try
            {
                db.BOOKS.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n" + e);
            }
        }

        public static void handleDelete(int Id)
        {
            var rmObj = db.BOOKS.SingleOrDefault(x => x.ID == Id);
            try
            {
                db.BOOKS.Remove(rmObj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e);
            }
        }

        public static void handleUpdate(BOOK a)
        {
            var udObj = db.BOOKS.SingleOrDefault(x => x.ID == a.ID);
            udObj = a;
            db.SaveChanges();
        }
    }
}

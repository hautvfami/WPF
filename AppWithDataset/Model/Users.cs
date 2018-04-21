using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithDataset.Model
{
    static class Users
    {
        private static Entities db = new Entities();

        public static List<USER> getAllUsers(){
            return db.USERS.OrderBy(x => x.ID).ToList();
        }

        public static void handleInsert(USER a)
        {
            try
            {
                db.USERS.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n" + e);
            }
        }

        public static void handleDelete(int Id)
        {
            var rmObj = db.USERS.SingleOrDefault(x => x.ID == Id);
            try
            {
                db.USERS.Remove(rmObj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e);
            }
        }

        public static void handleUpdate(USER a)
        {
            var udObj = db.USERS.SingleOrDefault(x => x.ID == a.ID);
            udObj = a;
            db.SaveChanges();
        }

        public static USER handleLogin(string u, string p)
        {
            var user = db.USERS.Find(u);
            if (user.PASSWORD == p && user.USERNAME == u)
            {
                return user;
            }
            return null;
        }
    }
}

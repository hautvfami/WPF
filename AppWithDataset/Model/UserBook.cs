using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppWithDataset.Model
{
    static class UserBook
    {
        private static Entities db = new Entities();

        public static List<USER_BOOK> getAllBill()
        {
            return db.USER_BOOK.ToList();
        }

        public static void handleBorrow(USER_BOOK a)
        {
            try
            {
                db.USER_BOOK.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n\n\n\n" + e);
                MessageBox.Show("Không thể mượn cuốn sách này nữa!");
            }
        }

        //public static void handleDelete(int Id)
        //{
        //    var rmObj = db.USERS.SingleOrDefault(x => x.ID == Id);
        //    try
        //    {
        //        db.USERS.Remove(rmObj);
        //        db.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error:\n" + e);
        //    }
        //}

        public static void handleReturn(USER_BOOK a)
        {
            var udObj = db.USER_BOOK.SingleOrDefault(x => x.USERID == a.USERID);
            udObj.IS_RETURN = true;
            db.SaveChanges();
        }
    }
}

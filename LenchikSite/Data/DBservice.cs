using LenchikSite.Net;
using Microsoft.EntityFrameworkCore;


namespace LenchikSite.Data;

public static class DBservice
{
    public static void Init_db()
    {
        using (DBContext db = new DBContext())
        {
            db.SaveChanges();
        }
    }

    public static void AddFurniture(string price, string image, string name, int categoryid)
    {
        using (DBContext db = new DBContext())
        {
            db.Furniture.Add(new Furniture { Price = price, Image = image, Name = name, Category = db.Category.FirstOrDefault(x => x.Id == categoryid) });
            db.SaveChanges();
        }
    }

    public static void RemoveFurniture(Furniture furniture)
    {
        using (DBContext db = new DBContext())
        {
            db.Furniture.Remove(furniture);
            db.SaveChanges();
        }
    }


    public static List<Furniture> furniture { get; set; } = new List<Furniture>();
    public static List<Category> category { get; set; } = new List<Category>();
    public static void GetDataFromDB()
    {
        using (DBContext db = new DBContext())
        {
            furniture = db.Furniture.ToList();
            category = db.Category.ToList();
        }
    }

    public static Tuple<bool, string> authadmin(string login, string pass)
    {
        using (DBContext db = new DBContext())
        {
            if (db.Client.ToList().Any(x => x.Login == login && x.Pass == pass))
            {
                return Tuple.Create(db.Client.ToList().Find(x => x.Login.Equals(login) && x.Pass.Equals(pass)).Root, login);
            }
            return Tuple.Create(false, "Вход");
        }
    }
}






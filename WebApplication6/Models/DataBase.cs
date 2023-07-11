namespace WebApplication6.Models
{
    public class DataBase
    {
        public static List<User> user = new List<User>()
        {
            new User(){Id = 1 ,Name = "Ali" , Fname = "Alavi" ,Phone ="01" ,NationalId = "10"},
            new User(){Id = 2 ,Name = "Reza" , Fname = "Razavi" ,Phone ="02" ,NationalId = "20"},
            new User(){Id = 3 ,Name = "Amin" , Fname = "Amini" ,Phone ="03" ,NationalId = "30"},
            new User(){Id = 4 ,Name = "Amir" , Fname = "Amiri" ,Phone ="04" ,NationalId = "40"}
        };
    }
}

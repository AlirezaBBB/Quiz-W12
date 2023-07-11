namespace WebApplication6.Models
{
    public class UserRepository : IUserRepository
    {
        public bool Login(string nationalId, string phone)
        {
            var validUser = DataBase.user.Find(u => u.NationalId == nationalId && u.Phone == phone);
            if (validUser != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}

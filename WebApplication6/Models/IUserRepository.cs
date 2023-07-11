namespace WebApplication6.Models
{
    public interface IUserRepository
    {
        bool Login(string nationalId, string phone);
    }
}

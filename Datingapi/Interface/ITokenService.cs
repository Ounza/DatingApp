using Datingapi.Entities;
namespace Datingapi.Interface
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
}
}
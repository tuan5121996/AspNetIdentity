using AspNetIdentity.Models.DTO;

namespace AspNetIdentity.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task<Status> RegistrationAsync(RegistrationModel model);   
        Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);   
        Task LogoutAsync();
    }
}

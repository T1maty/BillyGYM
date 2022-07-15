using BillyGym.Domain.Auth;
using BillyGym.Domain.Common;

namespace BillyGYM.Service.Contract
{
    public interface IAccountService
    {
        ValueTask<Response<AuthenticationResponse>> AutheticateAsync(AuthenticationRequest request, string ipAddress);
        ValueTask<Response<string>> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task ForgotPassword(ForgotPasswordRequest model, string origin);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);
    }
}

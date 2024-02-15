using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Imc;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private AuthenticationState _authenticationState;

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(_authenticationState);
    }

    public async Task SetAuthenticationState(AuthenticationState authenticationState)
    {
        _authenticationState = authenticationState;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        await Task.CompletedTask;
    }
}

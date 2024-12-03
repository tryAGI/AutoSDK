//HintName: G.IAccountClient.GetAccountDetailsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountDetailsForCurrentUser<br/>
        /// GetAccountDetailsForCurrentUser
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAccountDetailsForCurrentUserResponse> GetAccountDetailsForCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
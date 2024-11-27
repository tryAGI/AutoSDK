//HintName: G.IAccountClient.GetAccountForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountForCurrentUser<br/>
        /// GetAccountForCurrentUser
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAccountForCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
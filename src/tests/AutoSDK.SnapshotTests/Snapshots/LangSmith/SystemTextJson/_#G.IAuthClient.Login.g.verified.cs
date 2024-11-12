//HintName: G.IAuthClient.Login.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicAuthResponse> LoginAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
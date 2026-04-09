//HintName: G.IApi.GetIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets identity information via OpenID Connect
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetIdentityAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
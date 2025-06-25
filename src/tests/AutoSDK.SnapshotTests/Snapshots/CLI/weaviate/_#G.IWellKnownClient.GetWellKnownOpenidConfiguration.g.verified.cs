//HintName: G.IWellKnownClient.GetWellKnownOpenidConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// OIDC discovery information (if OIDC auth is enabled)<br/>
        /// OIDC Discovery page, redirects to the token issuer if one is configured
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> GetWellKnownOpenidConfigurationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
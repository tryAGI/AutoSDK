//HintName: G.IApi.Authorizations.OpenIdConnect.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the OpenID Connect discovery document URL for this scheme.
        /// </summary>
        public string OpenIdConnectDiscoveryUrl { get; }

        /// <summary>
        /// Authorize using an OpenID Connect access token.
        /// </summary>
        /// <param name="accessToken"></param>
        public void AuthorizeUsingOpenIdConnect(
            string accessToken);

        /// <summary>
        /// Authorize using an OpenID Connect access token and token type.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="tokenType"></param>
        public void AuthorizeUsingOpenIdConnect(
            string accessToken,
            string tokenType);
    }
}
//HintName: G.Api.Authorizations.OpenIdConnect.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Gets the OpenID Connect discovery document URL for this scheme.
        /// </summary>
        public string OpenIdConnectDiscoveryUrl => "https://example.com/.well-known/openid-configuration";

        /// <summary>
        /// Authorize using an OpenID Connect access token.
        /// </summary>
        /// <param name="accessToken"></param>
        public void AuthorizeUsingOpenIdConnect(
            string accessToken)
        {
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

            AuthorizeUsingOpenIdConnect(accessToken, "Bearer");
        }

        /// <summary>
        /// Authorize using an OpenID Connect access token and token type.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="tokenType"></param>
        public void AuthorizeUsingOpenIdConnect(
            string accessToken,
            string tokenType)
        {
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            tokenType = tokenType ?? throw new global::System.ArgumentNullException(nameof(tokenType));

            if (string.IsNullOrWhiteSpace(tokenType))
            {
                tokenType = "Bearer";
            }

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "OpenIdConnect" &&
                    __authorization.SchemeId == "OpenID")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "OpenIdConnect",
                SchemeId = "OpenID",
                Location = "Header",
                Name = tokenType,
                Value = accessToken,
            });
        }
    }
}
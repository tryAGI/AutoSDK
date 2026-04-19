//HintName: G.Api.Constructors.OAuth2.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc cref="Api(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::G.EndPointAuthorization}?, bool)"/>

        public Api(
            string accessToken,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref accessToken);

            AuthorizeUsingOAuth2(accessToken);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string accessToken);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}
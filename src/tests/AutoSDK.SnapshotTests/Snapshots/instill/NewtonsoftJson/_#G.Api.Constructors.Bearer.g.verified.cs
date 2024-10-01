//HintName: G.Api.Constructors.Bearer.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc cref="Api(global::System.Net.Http.HttpClient?, global::System.Uri?, global::G.EndPointAuthorization?)"/>
        public Api(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::G.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}
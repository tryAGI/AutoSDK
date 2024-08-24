//HintName: G.Api.Constructors.Bearer.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc cref="Api(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public Api(
            string apiKey,

            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}
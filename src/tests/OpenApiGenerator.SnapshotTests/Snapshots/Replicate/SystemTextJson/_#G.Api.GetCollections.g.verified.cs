//HintName: G.Api.GetCollections.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGetCollectionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionSlug);
        partial void PrepareGetCollectionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionSlug);
        partial void ProcessGetCollectionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get a collection of models<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/collections/super-resolution<br/>
        /// ```<br/>
        /// The response will be a collection object with a nested list of the models in that collection:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "name": "Super resolution",<br/>
        ///   "slug": "super-resolution",<br/>
        ///   "description": "Upscaling models that create high-quality images from low-quality images.",<br/>
        ///   "models": [...]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="collectionSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task GetCollectionsAsync(
            string collectionSlug,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCollectionsArguments(
                httpClient: _httpClient,
                collectionSlug: ref collectionSlug);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/collections/{collectionSlug}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCollectionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                collectionSlug: collectionSlug);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCollectionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}
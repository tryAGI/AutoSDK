//HintName: G.Api.GetCollections.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/collections/{collectionSlug}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
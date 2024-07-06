//HintName: G.Api.ListModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// List public models<br/>
        /// Get a paginated list of public models.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of model objects:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "url": "https://replicate.com/acme/hello-world",<br/>
        ///       "owner": "acme",<br/>
        ///       "name": "hello-world",<br/>
        ///       "description": "A tiny model that says hello",<br/>
        ///       "visibility": "public",<br/>
        ///       "github_url": "https://github.com/replicate/cog-examples",<br/>
        ///       "paper_url": null,<br/>
        ///       "license_url": null,<br/>
        ///       "run_count": 5681081,<br/>
        ///       "cover_image_url": "...",<br/>
        ///       "default_example": {...},<br/>
        ///       "latest_version": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The `cover_image_url` string is an HTTPS URL for an image file. This can be:<br/>
        /// - An image uploaded by the model author.<br/>
        /// - The output file of the example prediction, if the model author has not set a cover image.<br/>
        /// - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.<br/>
        /// - A generic fallback image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/models", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
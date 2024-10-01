//HintName: G.Api.ListModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareListModelsArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareListModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessListModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
            PrepareArguments(
                client: _httpClient);
            PrepareListModelsArguments(
                httpClient: _httpClient);

            var __pathBuilder = new PathBuilder(
                path: "/models",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListModelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListModelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}
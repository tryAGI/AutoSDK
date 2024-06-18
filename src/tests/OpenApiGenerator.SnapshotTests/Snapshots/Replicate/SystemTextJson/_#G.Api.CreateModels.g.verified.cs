//HintName: G.Api.CreateModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "my-model", "description": "An example model", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/my-model",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "my-model",<br/>
        ///   "description": "An example model",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateModelsAsync(
            global::G.CreateModelsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/models", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "my-model", "description": "An example model", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/my-model",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "my-model",<br/>
        ///   "description": "An example model",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="coverImageUrl"></param>
        /// <param name="description"></param>
        /// <param name="githubUrl"></param>
        /// <param name="hardware"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="paperUrl"></param>
        /// <param name="visibility"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateModelsAsync(
            string hardware,
            string name,
            string owner,
            global::G.CreateModelsRequestVisibility visibility,
            string? coverImageUrl = default,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateModelsRequest
            {
                CoverImageUrl = coverImageUrl,
                Description = description,
                GithubUrl = githubUrl,
                Hardware = hardware,
                LicenseUrl = licenseUrl,
                Name = name,
                Owner = owner,
                PaperUrl = paperUrl,
                Visibility = visibility,
            };

            await CreateModelsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
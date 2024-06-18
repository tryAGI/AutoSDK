//HintName: G.Api.CreateDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a deployment<br/>
        /// Create a new deployment:<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///         "name": "my-app-image-generator",<br/>
        ///         "model": "stability-ai/sdxl",<br/>
        ///         "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///         "hardware": "gpu-t4",<br/>
        ///         "min_instances": 0,<br/>
        ///         "max_instances": 3<br/>
        ///       }' \<br/>
        ///   https://api.replicate.com/v1/deployments<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 1,<br/>
        ///     "model": "stability-ai/sdxl",<br/>
        ///     "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///     "created_by": {<br/>
        ///       "type": "organization",<br/>
        ///       "username": "acme",<br/>
        ///       "name": "Acme Corp, Inc.",<br/>
        ///       "github_url": "https://github.com/acme",<br/>
        ///     },<br/>
        ///     "configuration": {<br/>
        ///       "hardware": "gpu-t4",<br/>
        ///       "min_instances": 1,<br/>
        ///       "max_instances": 5<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDeploymentsResponse> CreateDeploymentsAsync(
            global::G.CreateDeploymentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/deployments", global::System.UriKind.RelativeOrAbsolute));
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

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateDeploymentsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a deployment<br/>
        /// Create a new deployment:<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///         "name": "my-app-image-generator",<br/>
        ///         "model": "stability-ai/sdxl",<br/>
        ///         "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///         "hardware": "gpu-t4",<br/>
        ///         "min_instances": 0,<br/>
        ///         "max_instances": 3<br/>
        ///       }' \<br/>
        ///   https://api.replicate.com/v1/deployments<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 1,<br/>
        ///     "model": "stability-ai/sdxl",<br/>
        ///     "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///     "created_by": {<br/>
        ///       "type": "organization",<br/>
        ///       "username": "acme",<br/>
        ///       "name": "Acme Corp, Inc.",<br/>
        ///       "github_url": "https://github.com/acme",<br/>
        ///     },<br/>
        ///     "configuration": {<br/>
        ///       "hardware": "gpu-t4",<br/>
        ///       "min_instances": 1,<br/>
        ///       "max_instances": 5<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="hardware"></param>
        /// <param name="maxInstances"></param>
        /// <param name="minInstances"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDeploymentsResponse> CreateDeploymentsAsync(
            string hardware,
            int maxInstances,
            int minInstances,
            string model,
            string name,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateDeploymentsRequest
            {
                Hardware = hardware,
                MaxInstances = maxInstances,
                MinInstances = minInstances,
                Model = model,
                Name = name,
                Version = version,
            };

            return await CreateDeploymentsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
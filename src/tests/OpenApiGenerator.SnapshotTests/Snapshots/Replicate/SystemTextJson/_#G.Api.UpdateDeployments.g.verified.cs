//HintName: G.Api.UpdateDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareUpdateDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deploymentOwner,
            ref string deploymentName,
            global::G.UpdateDeploymentsRequest request);
        partial void PrepareUpdateDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deploymentOwner,
            string deploymentName,
            global::G.UpdateDeploymentsRequest request);
        partial void ProcessUpdateDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a deployment<br/>
        /// Update properties of an existing deployment, including hardware, min/max instances, and the deployment's underlying model [version](https://replicate.com/docs/how-does-replicate-work#versions).<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X PATCH \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"min_instances": 3, "max_instances": 10}' \<br/>
        ///   https://api.replicate.com/v1/deployments/acme/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 2,<br/>
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
        ///       "min_instances": 3,<br/>
        ///       "max_instances": 10<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Updating any deployment properties will increment the `number` field of the `current_release`.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateDeploymentsResponse> UpdateDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
            global::G.UpdateDeploymentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateDeploymentsArguments(
                httpClient: _httpClient,
                deploymentOwner: ref deploymentOwner,
                deploymentName: ref deploymentName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/deployments/{deploymentOwner}/{deploymentName}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateDeploymentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateDeploymentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateDeploymentsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateDeploymentsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a deployment<br/>
        /// Update properties of an existing deployment, including hardware, min/max instances, and the deployment's underlying model [version](https://replicate.com/docs/how-does-replicate-work#versions).<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X PATCH \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"min_instances": 3, "max_instances": 10}' \<br/>
        ///   https://api.replicate.com/v1/deployments/acme/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 2,<br/>
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
        ///       "min_instances": 3,<br/>
        ///       "max_instances": 10<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Updating any deployment properties will increment the `number` field of the `current_release`.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="hardware"></param>
        /// <param name="maxInstances"></param>
        /// <param name="minInstances"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateDeploymentsResponse> UpdateDeploymentsAsync(
            string deploymentOwner,
            string deploymentName,
            string? hardware = default,
            int maxInstances = default,
            int minInstances = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateDeploymentsRequest
            {
                Hardware = hardware,
                MaxInstances = maxInstances,
                MinInstances = minInstances,
                Version = version,
            };

            return await UpdateDeploymentsAsync(
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
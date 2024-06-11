//HintName: G.Api.UpdateDeployments.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Update a deployment
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/deployments/{deploymentOwner}/{deploymentName}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateDeploymentsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a deployment
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
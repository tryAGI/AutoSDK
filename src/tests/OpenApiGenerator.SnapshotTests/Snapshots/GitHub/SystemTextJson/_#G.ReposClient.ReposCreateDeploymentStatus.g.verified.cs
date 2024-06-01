//HintName: G.ReposClient.ReposCreateDeploymentStatus.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a deployment status
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DeploymentStatus> ReposCreateDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            ReposCreateDeploymentStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/deployments/{deploymentId}/statuses", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<DeploymentStatus?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a deployment status
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="state"></param>
        /// <param name="targetUrl"></param>
        /// <param name="logUrl"></param>
        /// <param name="description"></param>
        /// <param name="environment"></param>
        /// <param name="environmentUrl"></param>
        /// <param name="autoInactive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DeploymentStatus> ReposCreateDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            ReposCreateDeploymentStatusRequestState state,
            string? targetUrl = "",
            string? logUrl = "",
            string? description = "",
            string? environment = default,
            string? environmentUrl = "",
            bool autoInactive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateDeploymentStatusRequest
            {
                State = state,
                TargetUrl = targetUrl,
                LogUrl = logUrl,
                Description = description,
                Environment = environment,
                EnvironmentUrl = environmentUrl,
                AutoInactive = autoInactive,
            };

            return await ReposCreateDeploymentStatusAsync(
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
//HintName: G.ReposClient.ReposCreateOrUpdateEnvironment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create or update an environment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            ReposCreateOrUpdateEnvironmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/environments/{environmentName}", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<Environment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update an environment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="waitTimer"></param>
        /// <param name="preventSelfReview"></param>
        /// <param name="reviewers"></param>
        /// <param name="deploymentBranchPolicy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            int waitTimer = default,
            bool preventSelfReview = default,
            global::System.Collections.Generic.IList<ReposCreateOrUpdateEnvironmentRequestReviewers?>? reviewers = default,
            DeploymentBranchPolicySettings? deploymentBranchPolicy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateOrUpdateEnvironmentRequest
            {
                WaitTimer = waitTimer,
                PreventSelfReview = preventSelfReview,
                Reviewers = reviewers,
                DeploymentBranchPolicy = deploymentBranchPolicy,
            };

            return await ReposCreateOrUpdateEnvironmentAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
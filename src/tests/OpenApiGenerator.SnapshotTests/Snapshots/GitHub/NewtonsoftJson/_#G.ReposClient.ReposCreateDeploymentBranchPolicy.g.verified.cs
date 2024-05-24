//HintName: G.ReposClient.ReposCreateDeploymentBranchPolicy.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a deployment branch policy
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            DeploymentBranchPolicyNamePatternWithType request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/environments/{environmentName}/deployment-branch-policies", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<DeploymentBranchPolicy>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Create a deployment branch policy
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            string name,
            DeploymentBranchPolicyNamePatternWithTypeType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new DeploymentBranchPolicyNamePatternWithType
            {
                Name = name,
                Type = type,
            };

            return await ReposCreateDeploymentBranchPolicyAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
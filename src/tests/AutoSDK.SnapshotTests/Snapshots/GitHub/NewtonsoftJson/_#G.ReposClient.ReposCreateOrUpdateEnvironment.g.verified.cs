//HintName: G.ReposClient.ReposCreateOrUpdateEnvironment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateOrUpdateEnvironmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            global::G.ReposCreateOrUpdateEnvironmentRequest request);
        partial void PrepareReposCreateOrUpdateEnvironmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            global::G.ReposCreateOrUpdateEnvironmentRequest request);
        partial void ProcessReposCreateOrUpdateEnvironmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateOrUpdateEnvironmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update an environment<br/>
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see "[Environments](/actions/reference/environments#environment-protection-rules)."<br/>
        /// **Note:** To create or update name patterns that branches must match in order to deploy to this environment, see "[Deployment branch policies](/rest/deployments/branch-policies)."<br/>
        /// **Note:** To create or update secrets for an environment, see "[GitHub Actions secrets](/rest/actions/secrets)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            global::G.ReposCreateOrUpdateEnvironmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateOrUpdateEnvironmentArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateOrUpdateEnvironmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateOrUpdateEnvironmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateOrUpdateEnvironmentResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Environment?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update an environment<br/>
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see "[Environments](/actions/reference/environments#environment-protection-rules)."<br/>
        /// **Note:** To create or update name patterns that branches must match in order to deploy to this environment, see "[Deployment branch policies](/rest/deployments/branch-policies)."<br/>
        /// **Note:** To create or update secrets for an environment, see "[GitHub Actions secrets](/rest/actions/secrets)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="waitTimer">
        /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).<br/>
        /// Example: 30
        /// </param>
        /// <param name="preventSelfReview">
        /// Whether or not a user who created the job is prevented from approving their own job.<br/>
        /// Example: false
        /// </param>
        /// <param name="reviewers">
        /// The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </param>
        /// <param name="deploymentBranchPolicy">
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            int? waitTimer = default,
            bool? preventSelfReview = default,
            global::System.Collections.Generic.IList<global::G.ReposCreateOrUpdateEnvironmentRequestReviewer>? reviewers = default,
            global::G.DeploymentBranchPolicySettings? deploymentBranchPolicy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateOrUpdateEnvironmentRequest
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
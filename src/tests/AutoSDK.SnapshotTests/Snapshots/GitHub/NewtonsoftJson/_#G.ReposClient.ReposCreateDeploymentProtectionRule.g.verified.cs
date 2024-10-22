//HintName: G.ReposClient.ReposCreateDeploymentProtectionRule.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateDeploymentProtectionRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string environmentName,
            ref string repo,
            ref string owner,
            global::G.ReposCreateDeploymentProtectionRuleRequest request);
        partial void PrepareReposCreateDeploymentProtectionRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string environmentName,
            string repo,
            string owner,
            global::G.ReposCreateDeploymentProtectionRuleRequest request);
        partial void ProcessReposCreateDeploymentProtectionRuleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateDeploymentProtectionRuleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a custom deployment protection rule on an environment<br/>
        /// Enable a custom deployment protection rule for an environment.<br/>
        /// The authenticated user must have admin or owner permissions to the repository to use this endpoint.<br/>
        /// For more information about the app that is providing this custom deployment rule, see the [documentation for the `GET /apps/{app_slug}` endpoint](https://docs.github.com/rest/apps/apps#get-an-app).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="environmentName"></param>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentProtectionRule> ReposCreateDeploymentProtectionRuleAsync(
            string environmentName,
            string repo,
            string owner,
            global::G.ReposCreateDeploymentProtectionRuleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposCreateDeploymentProtectionRuleArguments(
                httpClient: HttpClient,
                environmentName: ref environmentName,
                repo: ref repo,
                owner: ref owner,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/deployment_protection_rules",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposCreateDeploymentProtectionRuleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposCreateDeploymentProtectionRuleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreateDeploymentProtectionRuleResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.DeploymentProtectionRule.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a custom deployment protection rule on an environment<br/>
        /// Enable a custom deployment protection rule for an environment.<br/>
        /// The authenticated user must have admin or owner permissions to the repository to use this endpoint.<br/>
        /// For more information about the app that is providing this custom deployment rule, see the [documentation for the `GET /apps/{app_slug}` endpoint](https://docs.github.com/rest/apps/apps#get-an-app).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="environmentName"></param>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="integrationId">
        /// The ID of the custom app that will be enabled on the environment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentProtectionRule> ReposCreateDeploymentProtectionRuleAsync(
            string environmentName,
            string repo,
            string owner,
            int? integrationId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ReposCreateDeploymentProtectionRuleRequest
            {
                IntegrationId = integrationId,
            };

            return await ReposCreateDeploymentProtectionRuleAsync(
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
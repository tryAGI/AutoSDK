//HintName: G.ReposClient.ReposDisableDeploymentProtectionRule.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposDisableDeploymentProtectionRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string environmentName,
            ref string repo,
            ref string owner,
            ref int protectionRuleId);
        partial void PrepareReposDisableDeploymentProtectionRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string environmentName,
            string repo,
            string owner,
            int protectionRuleId);
        partial void ProcessReposDisableDeploymentProtectionRuleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Disable a custom protection rule for an environment<br/>
        /// Disables a custom deployment protection rule for an environment.<br/>
        /// The authenticated user must have admin or owner permissions to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="environmentName"></param>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="protectionRuleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ReposDisableDeploymentProtectionRuleAsync(
            string environmentName,
            string repo,
            string owner,
            int protectionRuleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposDisableDeploymentProtectionRuleArguments(
                httpClient: HttpClient,
                environmentName: ref environmentName,
                repo: ref repo,
                owner: ref owner,
                protectionRuleId: ref protectionRuleId);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/deployment_protection_rules/{protectionRuleId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposDisableDeploymentProtectionRuleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                protectionRuleId: protectionRuleId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposDisableDeploymentProtectionRuleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

            }
        }
    }
}
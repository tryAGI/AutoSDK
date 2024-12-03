//HintName: G.ReposClient.ReposUpdateDeploymentBranchPolicy.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateDeploymentBranchPolicyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            ref int branchPolicyId,
            global::G.DeploymentBranchPolicyNamePattern request);
        partial void PrepareReposUpdateDeploymentBranchPolicyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            int branchPolicyId,
            global::G.DeploymentBranchPolicyNamePattern request);
        partial void ProcessReposUpdateDeploymentBranchPolicyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateDeploymentBranchPolicyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a deployment branch policy<br/>
        /// Updates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="branchPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentBranchPolicy> ReposUpdateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            int branchPolicyId,
            global::G.DeploymentBranchPolicyNamePattern request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposUpdateDeploymentBranchPolicyArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                branchPolicyId: ref branchPolicyId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/deployment-branch-policies/{branchPolicyId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposUpdateDeploymentBranchPolicyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                branchPolicyId: branchPolicyId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposUpdateDeploymentBranchPolicyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReposUpdateDeploymentBranchPolicyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
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

                return
                    global::G.DeploymentBranchPolicy.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.DeploymentBranchPolicy.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update a deployment branch policy<br/>
        /// Updates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="branchPolicyId"></param>
        /// <param name="name">
        /// The name pattern that branches must match in order to deploy to the environment.<br/>
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.<br/>
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).<br/>
        /// Example: release/*
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeploymentBranchPolicy> ReposUpdateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            int branchPolicyId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.DeploymentBranchPolicyNamePattern
            {
                Name = name,
            };

            return await ReposUpdateDeploymentBranchPolicyAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                branchPolicyId: branchPolicyId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
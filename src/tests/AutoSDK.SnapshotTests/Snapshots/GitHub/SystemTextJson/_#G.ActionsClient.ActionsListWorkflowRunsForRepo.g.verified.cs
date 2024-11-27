//HintName: G.ActionsClient.ActionsListWorkflowRunsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsListWorkflowRunsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? actor,
            ref string? branch,
            ref string? @event,
            ref global::G.ActionsListWorkflowRunsForRepoStatus? status,
            ref int? perPage,
            ref int? page,
            ref global::System.DateTime? created,
            ref bool? excludePullRequests,
            ref int? checkSuiteId,
            ref string? headSha);
        partial void PrepareActionsListWorkflowRunsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? actor,
            string? branch,
            string? @event,
            global::G.ActionsListWorkflowRunsForRepoStatus? status,
            int? perPage,
            int? page,
            global::System.DateTime? created,
            bool? excludePullRequests,
            int? checkSuiteId,
            string? headSha);
        partial void ProcessActionsListWorkflowRunsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsListWorkflowRunsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List workflow runs for a repository<br/>
        /// Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#parameters).<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.<br/>
        /// This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="event"></param>
        /// <param name="status"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsListWorkflowRunsForRepoResponse> ActionsListWorkflowRunsForRepoAsync(
            string owner,
            string repo,
            string? actor = default,
            string? branch = default,
            string? @event = default,
            global::G.ActionsListWorkflowRunsForRepoStatus? status = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? created = default,
            bool? excludePullRequests = default,
            int? checkSuiteId = default,
            string? headSha = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsListWorkflowRunsForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                actor: ref actor,
                branch: ref branch,
                @event: ref @event,
                status: ref status,
                perPage: ref perPage,
                page: ref page,
                created: ref created,
                excludePullRequests: ref excludePullRequests,
                checkSuiteId: ref checkSuiteId,
                headSha: ref headSha);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("actor", actor) 
                .AddOptionalParameter("branch", branch) 
                .AddOptionalParameter("event", @event) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("created", created?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("exclude_pull_requests", excludePullRequests?.ToString()) 
                .AddOptionalParameter("check_suite_id", checkSuiteId?.ToString()) 
                .AddOptionalParameter("head_sha", headSha) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsListWorkflowRunsForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                actor: actor,
                branch: branch,
                @event: @event,
                status: status,
                perPage: perPage,
                page: page,
                created: created,
                excludePullRequests: excludePullRequests,
                checkSuiteId: checkSuiteId,
                headSha: headSha);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsListWorkflowRunsForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessActionsListWorkflowRunsForRepoResponseContent(
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
                    global::G.ActionsListWorkflowRunsForRepoResponse.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.ActionsListWorkflowRunsForRepoResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}
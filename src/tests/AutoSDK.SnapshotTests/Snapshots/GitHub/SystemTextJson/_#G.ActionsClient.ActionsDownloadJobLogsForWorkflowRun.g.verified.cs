//HintName: G.ActionsClient.ActionsDownloadJobLogsForWorkflowRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsDownloadJobLogsForWorkflowRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int jobId);
        partial void PrepareActionsDownloadJobLogsForWorkflowRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int jobId);
        partial void ProcessActionsDownloadJobLogsForWorkflowRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Download job logs for a workflow run<br/>
        /// Gets a redirect URL to download a plain text file of logs for a workflow job. This link expires after 1 minute. Look<br/>
        /// for `Location:` in the response header to find the URL for the download.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsDownloadJobLogsForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsDownloadJobLogsForWorkflowRunArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                jobId: ref jobId);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/jobs/{jobId}/logs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsDownloadJobLogsForWorkflowRunRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                jobId: jobId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsDownloadJobLogsForWorkflowRunResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}
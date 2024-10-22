//HintName: G.ActionsClient.ActionsDownloadWorkflowRunAttemptLogs.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsDownloadWorkflowRunAttemptLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runId,
            ref int attemptNumber);
        partial void PrepareActionsDownloadWorkflowRunAttemptLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runId,
            int attemptNumber);
        partial void ProcessActionsDownloadWorkflowRunAttemptLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Download workflow run attempt logs<br/>
        /// Gets a redirect URL to download an archive of log files for a specific workflow run attempt. This link expires after<br/>
        /// 1 minute. Look for `Location:` in the response header to find the URL for the download.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="attemptNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsDownloadWorkflowRunAttemptLogsAsync(
            string owner,
            string repo,
            int runId,
            int attemptNumber,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsDownloadWorkflowRunAttemptLogsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                runId: ref runId,
                attemptNumber: ref attemptNumber);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runs/{runId}/attempts/{attemptNumber}/logs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsDownloadWorkflowRunAttemptLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                runId: runId,
                attemptNumber: attemptNumber);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsDownloadWorkflowRunAttemptLogsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}
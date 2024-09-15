//HintName: G.IActionsClient.ActionsDownloadWorkflowRunAttemptLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
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
        global::System.Threading.Tasks.Task ActionsDownloadWorkflowRunAttemptLogsAsync(
            string owner,
            string repo,
            int runId,
            int attemptNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
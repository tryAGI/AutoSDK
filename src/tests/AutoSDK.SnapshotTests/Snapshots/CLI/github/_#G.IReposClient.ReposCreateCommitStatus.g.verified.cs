//HintName: G.IReposClient.ReposCreateCommitStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a commit status<br/>
        /// Users with push access in a repository can create commit statuses for a given SHA.<br/>
        /// Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a commit status<br/>
        /// Users with push access in a repository can create commit statuses for a given SHA.<br/>
        /// Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="state">
        /// The state of the status.
        /// </param>
        /// <param name="targetUrl">
        /// The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.  <br/>
        /// For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:  <br/>
        /// `http://ci.example.com/user/repo/build/sha`
        /// </param>
        /// <param name="description">
        /// A short description of the status.
        /// </param>
        /// <param name="context">
        /// A string label to differentiate this status from the status of other systems. This field is case-insensitive.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequestState state,
            string? targetUrl = default,
            string? description = default,
            string? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
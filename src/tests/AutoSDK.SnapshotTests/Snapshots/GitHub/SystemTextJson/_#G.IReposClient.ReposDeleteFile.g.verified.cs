//HintName: G.IReposClient.ReposDeleteFile.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file in a repository.<br/>
        /// You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.<br/>
        /// The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.<br/>
        /// You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If you use this endpoint and the "[Create or update file contents](https://docs.github.com/rest/repos/contents/#create-or-update-file-contents)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            global::G.ReposDeleteFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file in a repository.<br/>
        /// You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.<br/>
        /// The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.<br/>
        /// You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If you use this endpoint and the "[Create or update file contents](https://docs.github.com/rest/repos/contents/#create-or-update-file-contents)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="sha">
        /// The blob SHA of the file being deleted.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch
        /// </param>
        /// <param name="committer">
        /// object containing information about the committer.
        /// </param>
        /// <param name="author">
        /// object containing information about the author.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            string message,
            string sha,
            string? branch = default,
            global::G.ReposDeleteFileRequestCommitter? committer = default,
            global::G.ReposDeleteFileRequestAuthor? author = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
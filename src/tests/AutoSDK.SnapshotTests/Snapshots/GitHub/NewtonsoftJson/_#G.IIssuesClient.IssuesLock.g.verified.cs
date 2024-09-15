//HintName: G.IIssuesClient.IssuesLock.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Lock an issue<br/>
        /// Users with push access can lock an issue or pull request's conversation.<br/>
        /// Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> IssuesLockAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesLockRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Lock an issue<br/>
        /// Users with push access can lock an issue or pull request's conversation.<br/>
        /// Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="lockReason">
        /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  <br/>
        ///  * `off-topic`  <br/>
        ///  * `too heated`  <br/>
        ///  * `resolved`  <br/>
        ///  * `spam`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> IssuesLockAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesLockRequestLockReason? lockReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
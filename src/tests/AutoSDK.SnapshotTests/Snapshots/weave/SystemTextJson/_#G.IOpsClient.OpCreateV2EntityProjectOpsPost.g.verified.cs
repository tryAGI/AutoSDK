//HintName: G.IOpsClient.OpCreateV2EntityProjectOpsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IOpsClient
    {
        /// <summary>
        /// Op Create<br/>
        /// Create an op object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpCreateRes> OpCreateV2EntityProjectOpsPostAsync(
            string entity,
            string project,

            global::G.OpCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Op Create<br/>
        /// Create an op object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this op. Ops with the same name will be versioned together.
        /// </param>
        /// <param name="sourceCode">
        /// Complete source code for this op, including imports
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpCreateRes> OpCreateV2EntityProjectOpsPostAsync(
            string entity,
            string project,
            string? name = default,
            string? sourceCode = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
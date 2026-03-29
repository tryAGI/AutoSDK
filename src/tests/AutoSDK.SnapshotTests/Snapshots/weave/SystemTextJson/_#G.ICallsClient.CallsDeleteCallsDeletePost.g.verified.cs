//HintName: G.ICallsClient.CallsDeleteCallsDeletePost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsDeleteRes> CallsDeleteCallsDeletePostAsync(

            global::G.CallsDeleteReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Delete
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsDeleteRes> CallsDeleteCallsDeletePostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            string? wbUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
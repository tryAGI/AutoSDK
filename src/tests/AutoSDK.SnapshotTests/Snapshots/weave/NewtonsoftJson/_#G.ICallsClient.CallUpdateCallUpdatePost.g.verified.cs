//HintName: G.ICallsClient.CallUpdateCallUpdatePost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallUpdateRes> CallUpdateCallUpdatePostAsync(

            global::G.CallUpdateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callId"></param>
        /// <param name="displayName"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallUpdateRes> CallUpdateCallUpdatePostAsync(
            string projectId,
            string callId,
            string? displayName = default,
            string? wbUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.ILiveV2Client.StreamingControllerPatchRequestParamsV2.g.cs
#nullable enable

namespace G
{
    public partial interface ILiveV2Client
    {
        /// <summary>
        /// For debugging purposes, send post session metadata in the request params of the job
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingControllerPatchRequestParamsV2Async(
            string id,

            global::G.PatchRequestParamsDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// For debugging purposes, send post session metadata in the request params of the job
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingControllerPatchRequestParamsV2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
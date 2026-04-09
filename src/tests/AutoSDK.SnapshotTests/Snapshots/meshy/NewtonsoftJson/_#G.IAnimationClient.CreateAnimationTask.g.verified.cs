//HintName: G.IAnimationClient.CreateAnimationTask.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationClient
    {
        /// <summary>
        /// Create an Animation task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateAnimationTaskAsync(

            global::G.AnimationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Animation task
        /// </summary>
        /// <param name="rigTaskId">
        /// ID of completed rigging task
        /// </param>
        /// <param name="actionId">
        /// Animation action identifier
        /// </param>
        /// <param name="postProcess"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateAnimationTaskAsync(
            string rigTaskId,
            int actionId,
            global::G.AnimationPostProcess? postProcess = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
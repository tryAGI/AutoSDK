//HintName: G.IFeedbackClient.FeedbackCreateBatchFeedbackBatchCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Create Batch<br/>
        /// Add multiple feedback items to calls or objects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackCreateBatchRes> FeedbackCreateBatchFeedbackBatchCreatePostAsync(

            global::G.FeedbackCreateBatchReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Create Batch<br/>
        /// Add multiple feedback items to calls or objects.
        /// </summary>
        /// <param name="batch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackCreateBatchRes> FeedbackCreateBatchFeedbackBatchCreatePostAsync(
            global::System.Collections.Generic.IList<global::G.FeedbackCreateReq> batch,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
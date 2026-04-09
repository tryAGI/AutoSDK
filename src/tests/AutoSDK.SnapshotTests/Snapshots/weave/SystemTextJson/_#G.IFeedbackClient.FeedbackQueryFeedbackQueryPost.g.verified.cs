//HintName: G.IFeedbackClient.FeedbackQueryFeedbackQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Query<br/>
        /// Query for feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackQueryRes> FeedbackQueryFeedbackQueryPostAsync(

            global::G.FeedbackQueryReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Query<br/>
        /// Query for feedback.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="query"></param>
        /// <param name="sortBy"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackQueryRes> FeedbackQueryFeedbackQueryPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? fields = default,
            global::G.Query? query = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
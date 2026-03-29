//HintName: G.IFeedbackClient.FeedbackPurgeFeedbackPurgePost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Purge<br/>
        /// Permanently delete feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackPurgeRes> FeedbackPurgeFeedbackPurgePostAsync(

            global::G.FeedbackPurgeReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Purge<br/>
        /// Permanently delete feedback.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackPurgeRes> FeedbackPurgeFeedbackPurgePostAsync(
            string projectId,
            global::G.Query query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
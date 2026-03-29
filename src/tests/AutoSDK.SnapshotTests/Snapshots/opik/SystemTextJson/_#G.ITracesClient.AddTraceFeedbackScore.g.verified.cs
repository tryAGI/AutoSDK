//HintName: G.ITracesClient.AddTraceFeedbackScore.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Add trace feedback score<br/>
        /// Add trace feedback score
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AddTraceFeedbackScoreAsync(
            global::System.Guid id,

            global::G.FeedbackScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add trace feedback score<br/>
        /// Add trace feedback score
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryName"></param>
        /// <param name="value"></param>
        /// <param name="reason"></param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddTraceFeedbackScoreAsync(
            global::System.Guid id,
            string name,
            double value,
            global::G.FeedbackScoreSource source,
            string? categoryName = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
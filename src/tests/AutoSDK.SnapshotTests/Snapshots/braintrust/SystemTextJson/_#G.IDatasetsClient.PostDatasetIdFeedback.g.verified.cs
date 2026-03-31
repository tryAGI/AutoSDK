//HintName: G.IDatasetsClient.PostDatasetIdFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Feedback for dataset events<br/>
        /// Log feedback for a set of dataset events
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponseSchema> PostDatasetIdFeedbackAsync(
            global::System.Guid datasetId,

            global::G.FeedbackDatasetEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback for dataset events<br/>
        /// Log feedback for a set of dataset events
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="feedback">
        /// A list of dataset feedback items
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponseSchema> PostDatasetIdFeedbackAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::G.FeedbackDatasetItem> feedback,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
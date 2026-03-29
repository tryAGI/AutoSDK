//HintName: G.ITopicExtractionResultsClient.GetTopicExtractionResult.g.cs
#nullable enable

namespace G
{
    public partial interface ITopicExtractionResultsClient
    {
        /// <summary>
        /// Get Topic Extraction Result<br/>
        /// Returns the topic extraction result for a completed job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TopicExtractionResult> GetTopicExtractionResultAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
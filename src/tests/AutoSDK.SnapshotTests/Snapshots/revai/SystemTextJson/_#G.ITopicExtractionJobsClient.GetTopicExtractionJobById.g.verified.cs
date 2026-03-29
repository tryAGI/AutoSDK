//HintName: G.ITopicExtractionJobsClient.GetTopicExtractionJobById.g.cs
#nullable enable

namespace G
{
    public partial interface ITopicExtractionJobsClient
    {
        /// <summary>
        /// Get Topic Extraction Job By Id<br/>
        /// Returns information about a topic extraction job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TopicExtractionJob> GetTopicExtractionJobByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
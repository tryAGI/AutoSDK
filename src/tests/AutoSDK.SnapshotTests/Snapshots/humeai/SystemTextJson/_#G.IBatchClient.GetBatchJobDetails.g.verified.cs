//HintName: G.IBatchClient.GetBatchJobDetails.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get batch job details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InferenceJob> GetBatchJobDetailsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
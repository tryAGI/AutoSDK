//HintName: G.IApi.RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve Openai Batch
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetAsync(
            string batchId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
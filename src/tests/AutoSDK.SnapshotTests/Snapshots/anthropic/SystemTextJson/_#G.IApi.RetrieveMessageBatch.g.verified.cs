//HintName: G.IApi.RetrieveMessageBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve a Message Batch<br/>
        /// This endpoint is idempotent and can be used to poll for Message Batch<br/>
        /// completion. To access the results of a Message Batch, make a request to the<br/>
        /// `results_url` field in the response.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> RetrieveMessageBatchAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
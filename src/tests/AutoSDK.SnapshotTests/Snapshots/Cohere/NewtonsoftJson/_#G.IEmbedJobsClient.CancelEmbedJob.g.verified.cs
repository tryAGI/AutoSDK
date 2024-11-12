//HintName: G.IEmbedJobsClient.CancelEmbedJob.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbedJobsClient
    {
        /// <summary>
        /// Cancel an Embed Job<br/>
        /// This API allows users to cancel an active embed job. Once invoked, the embedding process will be terminated, and users will be charged for the embeddings processed up to the cancellation point. It's important to note that partial results will not be available to users after cancellation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CancelEmbedJobAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
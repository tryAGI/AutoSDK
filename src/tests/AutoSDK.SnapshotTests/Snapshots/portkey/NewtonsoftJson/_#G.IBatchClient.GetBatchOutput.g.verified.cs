//HintName: G.IBatchClient.GetBatchOutput.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Returns batch output as stream.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetBatchOutputAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
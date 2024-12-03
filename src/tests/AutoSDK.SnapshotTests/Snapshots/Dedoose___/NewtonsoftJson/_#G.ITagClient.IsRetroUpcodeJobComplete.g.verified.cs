//HintName: G.ITagClient.IsRetroUpcodeJobComplete.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// IsRetroUpcodeJobComplete<br/>
        /// IsRetroUpcodeJobComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsRetroUpcodeJobCompleteAsync(
            global::G.IsRetroUpcodeJobCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// IsRetroUpcodeJobComplete<br/>
        /// IsRetroUpcodeJobComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsRetroUpcodeJobCompleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
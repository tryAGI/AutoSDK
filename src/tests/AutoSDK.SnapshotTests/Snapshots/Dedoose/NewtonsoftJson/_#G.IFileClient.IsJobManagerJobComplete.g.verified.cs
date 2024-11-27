//HintName: G.IFileClient.IsJobManagerJobComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// IsJobManagerJobComplete<br/>
        /// IsJobManagerJobComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsJobManagerJobCompleteAsync(
            global::G.IsJobManagerJobCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// IsJobManagerJobComplete<br/>
        /// IsJobManagerJobComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsJobManagerJobCompleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IDescriptorClient.GetDesDataFromFileJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetDesDataFromFileJobResult<br/>
        /// GetDesDataFromFileJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesDataFromFileJobResultAsync(
            global::G.GetDesDataFromFileJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDesDataFromFileJobResult<br/>
        /// GetDesDataFromFileJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesDataFromFileJobResultAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
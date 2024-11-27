//HintName: G.IFileClient.GetMoveFileFromTempToPermJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetMoveFileFromTempToPermJobResult<br/>
        /// GetMoveFileFromTempToPermJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMoveFileFromTempToPermJobResultAsync(
            global::G.GetMoveFileFromTempToPermJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetMoveFileFromTempToPermJobResult<br/>
        /// GetMoveFileFromTempToPermJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetMoveFileFromTempToPermJobResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
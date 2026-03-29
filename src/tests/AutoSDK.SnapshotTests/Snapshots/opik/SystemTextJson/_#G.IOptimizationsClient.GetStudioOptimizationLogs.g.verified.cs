//HintName: G.IOptimizationsClient.GetStudioOptimizationLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Get Studio optimization logs<br/>
        /// Get presigned S3 URL for downloading optimization logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OptimizationStudioLog> GetStudioOptimizationLogsAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IOptimizationsClient.CreateOptimization.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Create optimization<br/>
        /// Create optimization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOptimizationAsync(

            global::G.OptimizationWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create optimization<br/>
        /// Create optimization
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="datasetName"></param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="objectiveName"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="studioConfig"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateOptimizationAsync(
            string datasetName,
            string objectiveName,
            global::G.OptimizationWriteStatus status,
            global::System.Guid? id = default,
            string? name = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::G.JsonListStringWrite? metadata = default,
            global::G.OptimizationStudioConfigWrite? studioConfig = default,
            global::System.DateTime? lastUpdatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
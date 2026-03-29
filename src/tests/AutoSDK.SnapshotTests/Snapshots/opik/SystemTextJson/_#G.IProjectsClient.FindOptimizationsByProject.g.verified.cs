//HintName: G.IProjectsClient.FindOptimizationsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find optimizations by project<br/>
        /// Find optimizations scoped to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="name">
        /// Filter optimizations by name (partial match, case insensitive)
        /// </param>
        /// <param name="datasetDeleted"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OptimizationPagePublic> FindOptimizationsByProjectAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Guid? datasetId = default,
            string? datasetName = default,
            string? name = default,
            bool? datasetDeleted = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
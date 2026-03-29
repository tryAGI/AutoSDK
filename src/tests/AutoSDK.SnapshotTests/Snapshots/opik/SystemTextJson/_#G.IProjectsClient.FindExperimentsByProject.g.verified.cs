//HintName: G.IProjectsClient.FindExperimentsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find experiments by project<br/>
        /// Find experiments scoped to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="optimizationId"></param>
        /// <param name="types"></param>
        /// <param name="name">
        /// Filter experiments by name (partial match, case insensitive)
        /// </param>
        /// <param name="datasetDeleted"></param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="experimentIds">
        /// Filter experiments by a list of experiment IDs
        /// </param>
        /// <param name="forceSorting">
        /// Force sorting even when exceeding the endpoint result set limit. May result in slower queries<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExperimentPagePublic> FindExperimentsByProjectAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Guid? datasetId = default,
            global::System.Guid? optimizationId = default,
            string? types = default,
            string? name = default,
            bool? datasetDeleted = default,
            string? sorting = default,
            string? filters = default,
            string? experimentIds = default,
            bool? forceSorting = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
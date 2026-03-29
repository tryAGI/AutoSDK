//HintName: G.IExperimentsClient.FindExperimentGroups.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Find experiment groups<br/>
        /// Find experiments grouped by specified fields
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="types"></param>
        /// <param name="name">
        /// Filter experiments by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="projectDeleted"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExperimentGroupResponse> FindExperimentGroupsAsync(
            string? groups = default,
            string? types = default,
            string? name = default,
            global::System.Guid? projectId = default,
            bool? projectDeleted = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
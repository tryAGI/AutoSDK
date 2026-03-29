//HintName: G.IProjectsClient.GetProjectStats.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Stats<br/>
        /// Get Project Stats
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter projects by name (partial match, case insensitive)
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectStatsSummary> GetProjectStatsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sorting = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
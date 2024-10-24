//HintName: G.IProjectsClient.ListProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Returns a list of projects.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="includeArchived">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectListResponse> ListProjectsAsync(
            int? limit = default,
            string? after = default,
            bool? includeArchived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
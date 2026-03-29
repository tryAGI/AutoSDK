//HintName: G.IBetaClient.ListDirectoriesApiV1BetaDirectoriesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Directories
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="name"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryQueryResponse> ListDirectoriesApiV1BetaDirectoriesGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? name = default,
            string? dataSourceId = default,
            bool? includeDeleted = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
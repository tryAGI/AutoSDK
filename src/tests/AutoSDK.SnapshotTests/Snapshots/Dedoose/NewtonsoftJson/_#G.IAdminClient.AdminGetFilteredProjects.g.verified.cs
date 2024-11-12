//HintName: G.IAdminClient.AdminGetFilteredProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetFilteredProjects.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminGetFilteredProjectsAsync(
            string? token = default,
            string? filter = default,
            int? maxResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
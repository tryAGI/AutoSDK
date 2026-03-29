//HintName: G.IProjects2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// List projects<br/>
        /// Retrieve a list of projects.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAllRolesProjectListList> ListAsync(
            bool? archived = default,
            string? filter = default,
            string? ids = default,
            string? include = default,
            int? membersLimit = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? state = default,
            string? title = default,
            double? workspaces = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
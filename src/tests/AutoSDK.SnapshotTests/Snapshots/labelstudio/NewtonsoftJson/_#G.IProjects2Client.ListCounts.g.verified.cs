//HintName: G.IProjects2Client.ListCounts.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// List projects' counts<br/>
        /// Returns a list of projects with their counts. For example, task_number which is the total task number in project
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLseProjectCountsList> ListCountsAsync(
            bool? archived = default,
            string? filter = default,
            string? ids = default,
            string? include = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? state = default,
            string? title = default,
            double? workspaces = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.ITasks2Client.List2.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// List tasks<br/>
        /// Retrieve a paginated list of tasks. The response format varies based on the user's role in the organization:<br/>
        /// - **Admin/Owner**: Full task details with all annotations, reviews, and metadata<br/>
        /// - **Reviewer**: Task details optimized for review workflow<br/>
        /// - **Annotator**: Task details filtered to show only user's own annotations and assignments
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="include"></param>
        /// <param name="onlyAnnotated"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="project"></param>
        /// <param name="query"></param>
        /// <param name="resolveUri"></param>
        /// <param name="review"></param>
        /// <param name="selectedItems"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedRoleBasedTaskList> List2Async(
            global::G.ApiTasksListFields? fields = default,
            string? include = default,
            bool? onlyAnnotated = default,
            int? page = default,
            int? pageSize = default,
            int? project = default,
            string? query = default,
            bool? resolveUri = default,
            bool? review = default,
            string? selectedItems = default,
            int? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
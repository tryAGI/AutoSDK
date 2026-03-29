//HintName: G.IProjectsClient.ApiProjectsTasksList.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project tasks<br/>
        ///             Retrieve a paginated list of tasks for a specific project. For example, use the following cURL command:<br/>
        ///             ```bash<br/>
        ///             curl -X GET http://localhost:8000/api/projects/{id}/tasks/?page=1&amp;page_size=10 -H 'Authorization: Token abc123'<br/>
        ///             ```<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TaskSimple>> ApiProjectsTasksListAsync(
            int id,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
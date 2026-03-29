//HintName: G.IProjectsClient.List2.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// ✨ Get project members paginated<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve the members for a specific project.<br/>
        /// **Response Fields:**<br/>
        /// - `implicit_member` (boolean): Indicates if the user is an implicit member.<br/>
        ///   - `true`: User has access via workspace membership or organization role (Administrator/Owner)<br/>
        ///   - `false`: User is an explicit project member (added directly to the project)<br/>
        /// - `project_role` (string|null): Project-specific role override if assigned, null otherwise<br/>
        /// **Note:** Users can have both explicit membership AND implicit access. The `implicit_member` field is `false` if the user has an explicit ProjectMember entry, regardless of whether they also have implicit access via workspace or org role.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="implicit"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="noAnnotators"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="withDeleted"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedPaginatedProjectMemberList> List2Async(
            int id,
            string? ids = default,
            bool? @implicit = default,
            global::System.DateTime? lastActivityGte = default,
            global::System.DateTime? lastActivityLte = default,
            bool? noAnnotators = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            bool? withDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IBetaClient.QueryFilesApiV1BetaFilesQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Query Files<br/>
        /// Query files with flexible filtering and pagination.<br/>
        /// **Deprecated**: Use GET /files instead for listing files with query parameters.<br/>
        /// Args:<br/>
        ///     request: The query request with filters and pagination<br/>
        ///     project: Validated project from dependency<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     Paginated response with files
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.FileQueryResponseV2> QueryFilesApiV1BetaFilesQueryPostAsync(

            global::G.FileQueryRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Files<br/>
        /// Query files with flexible filtering and pagination.<br/>
        /// **Deprecated**: Use GET /files instead for listing files with query parameters.<br/>
        /// Args:<br/>
        ///     request: The query request with filters and pagination<br/>
        ///     project: Validated project from dependency<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     Paginated response with files
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="pageSize">
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="filter">
        /// A filter object or expression that filters resources listed in the response.
        /// </param>
        /// <param name="orderBy">
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.FileQueryResponseV2> QueryFilesApiV1BetaFilesQueryPostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? pageSize = default,
            string? pageToken = default,
            global::G.FileFilter? filter = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IBetaClient.ListFilesApiV1BetaFilesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Files<br/>
        /// List files with optional filtering and pagination.<br/>
        /// Filter by `file_name`, `file_ids`, or `external_file_id`.<br/>
        /// Supports cursor-based pagination and custom ordering.
        /// </summary>
        /// <param name="pageSize">
        /// The maximum number of items to return. Defaults to 50, maximum is 1000.
        /// </param>
        /// <param name="pageToken">
        /// A page token received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="fileIds">
        /// Filter by specific file IDs.
        /// </param>
        /// <param name="fileName">
        /// Filter by file name (exact match).
        /// </param>
        /// <param name="externalFileId">
        /// Filter by external file ID.
        /// </param>
        /// <param name="orderBy">
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileQueryResponseV2> ListFilesApiV1BetaFilesGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            string? fileName = default,
            string? externalFileId = default,
            string? orderBy = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
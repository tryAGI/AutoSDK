//HintName: G.IObjectsClient.ObjsQueryObjsQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Objs Query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjQueryRes> ObjsQueryObjsQueryPostAsync(

            global::G.ObjQueryReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Objs Query
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to query
        /// </param>
        /// <param name="filter">
        /// Filter criteria for the query. See `ObjectVersionFilter`
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return
        /// </param>
        /// <param name="offset">
        /// Number of results to skip before returning
        /// </param>
        /// <param name="sortBy">
        /// Sorting criteria for the query results. Currently only supports 'object_id' and 'created_at'.
        /// </param>
        /// <param name="metadataOnly">
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// If true, the `size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTagsAndAliases">
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObjQueryRes> ObjsQueryObjsQueryPostAsync(
            string projectId,
            global::G.ObjectVersionFilter? filter = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            bool? metadataOnly = default,
            bool? includeStorageSize = default,
            bool? includeTagsAndAliases = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
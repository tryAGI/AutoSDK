//HintName: G.ITablesClient.TableQueryTableQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableQueryRes> TableQueryTableQueryPostAsync(

            global::G.TableQueryReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Query
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="digest">
        /// The digest of the table to query
        /// </param>
        /// <param name="filter">
        /// Optional filter to apply to the query. See `TableRowFilter` for more details.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rows to return
        /// </param>
        /// <param name="offset">
        /// Number of rows to skip before starting to return rows
        /// </param>
        /// <param name="sortBy">
        /// List of fields to sort by. Fields can be dot-separated to access dictionary values. No sorting uses the default table order (insertion order).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableQueryRes> TableQueryTableQueryPostAsync(
            string projectId,
            string digest,
            global::G.TableRowFilter? filter = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
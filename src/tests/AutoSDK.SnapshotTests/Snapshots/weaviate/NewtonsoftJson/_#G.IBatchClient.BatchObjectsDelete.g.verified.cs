//HintName: G.IBatchClient.BatchObjectsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Batch delete objects.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchDeleteResponse> BatchObjectsDeleteAsync(
            global::G.BatchDelete request,
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel = global::G.BatchObjectsDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Batch delete objects.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="dryRun">
        /// If true, the call will show which objects would be matched using the specified filter without deleting any objects. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of affected objects, or a list of IDs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchDeleteResponse> BatchObjectsDeleteAsync(
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel = global::G.BatchObjectsDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::G.BatchDeleteMatch? match = default,
            global::G.BatchDeleteOutput? output = global::G.BatchDeleteOutput.Minimal,
            bool? dryRun = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
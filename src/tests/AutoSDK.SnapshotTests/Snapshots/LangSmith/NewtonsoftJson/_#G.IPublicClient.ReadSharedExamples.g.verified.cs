//HintName: G.IPublicClient.ReadSharedExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Examples<br/>
        /// Get example by ids or the shared example if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> ReadSharedExamplesAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
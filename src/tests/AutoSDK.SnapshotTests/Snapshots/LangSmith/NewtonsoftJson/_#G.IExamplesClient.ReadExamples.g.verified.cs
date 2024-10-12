//HintName: G.IExamplesClient.ReadExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Read Examples<br/>
        /// Get all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="order"></param>
        /// <param name="randomSeed"></param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, source_run_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> ReadExamplesAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::G.AnyOf<string, object>? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits = default,
            global::G.AnyOf<global::System.Guid?, object>? dataset = default,
            int? offset = 0,
            int? limit = 100,
            global::G.ExampleListOrder? order = default,
            global::G.AnyOf<double?, object>? randomSeed = default,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select = default,
            global::G.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
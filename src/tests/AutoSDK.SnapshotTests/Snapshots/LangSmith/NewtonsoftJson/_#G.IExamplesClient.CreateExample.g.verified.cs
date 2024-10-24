//HintName: G.IExamplesClient.CreateExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Example> CreateExampleAsync(
            global::G.ExampleCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="datasetId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="inputs"></param>
        /// <param name="split">
        /// Default Value: base
        /// </param>
        /// <param name="id"></param>
        /// <param name="useSourceRunIo">
        /// Default Value: false
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Example> CreateExampleAsync(
            global::System.Guid datasetId,
            object? outputs = default,
            global::System.Guid? sourceRunId = default,
            object? metadata = default,
            object? inputs = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split = default,
            global::System.Guid? id = default,
            bool? useSourceRunIo = default,
            global::System.DateTime? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
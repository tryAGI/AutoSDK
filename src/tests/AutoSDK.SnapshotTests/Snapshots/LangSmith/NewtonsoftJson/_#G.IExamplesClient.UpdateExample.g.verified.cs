//HintName: G.IExamplesClient.UpdateExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::G.AnyOf<global::G.ExampleUpdateInputs, object>? inputs = default,
            global::G.AnyOf<global::G.ExampleUpdateOutputs, object>? outputs = default,
            global::G.AnyOf<global::G.ExampleUpdateMetadata, object>? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
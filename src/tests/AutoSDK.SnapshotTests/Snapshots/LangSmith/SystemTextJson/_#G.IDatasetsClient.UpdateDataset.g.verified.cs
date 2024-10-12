//HintName: G.IDatasetsClient.UpdateDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::G.DatasetUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="patchExamples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<string, global::G.Missing>? name = default,
            global::G.AnyOf<string, global::G.Missing>? description = default,
            global::G.AnyOf<object, global::G.Missing>? inputsSchemaDefinition = default,
            global::G.AnyOf<object, global::G.Missing>? outputsSchemaDefinition = default,
            global::System.Collections.Generic.Dictionary<string, global::G.ExampleUpdate>? patchExamples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
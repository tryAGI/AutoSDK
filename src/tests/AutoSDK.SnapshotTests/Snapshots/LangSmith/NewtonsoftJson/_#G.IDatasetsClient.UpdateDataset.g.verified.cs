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
            global::G.AnyOf<string, global::G.Missing, object>? name = default,
            global::G.AnyOf<string, global::G.Missing, object>? description = default,
            global::G.AnyOf<global::G.DatasetUpdateInputsSchemaDefinition, global::G.Missing, object>? inputsSchemaDefinition = default,
            global::G.AnyOf<global::G.DatasetUpdateOutputsSchemaDefinition, global::G.Missing, object>? outputsSchemaDefinition = default,
            global::G.AnyOf<global::G.DatasetUpdatePatchExamples, object>? patchExamples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
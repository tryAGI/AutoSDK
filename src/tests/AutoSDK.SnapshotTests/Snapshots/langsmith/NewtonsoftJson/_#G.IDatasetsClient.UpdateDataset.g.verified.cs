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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::G.DatasetUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples"></param>
        /// <param name="transformations">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<string, global::G.Missing, object>? name = default,
            global::G.AnyOf<string, global::G.Missing, object>? description = default,
            global::G.AnyOf<object, global::G.Missing, object>? inputsSchemaDefinition = default,
            global::G.AnyOf<object, global::G.Missing, object>? outputsSchemaDefinition = default,
            global::System.Collections.Generic.Dictionary<string, global::G.ExampleUpdate>? patchExamples = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DatasetTransformation>, global::G.Missing, object>? transformations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
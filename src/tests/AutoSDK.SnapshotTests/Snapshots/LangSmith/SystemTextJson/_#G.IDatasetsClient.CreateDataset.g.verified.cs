//HintName: G.IDatasetsClient.CreateDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> CreateDatasetAsync(
            global::G.DatasetCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="extra"></param>
        /// <param name="dataType">
        /// Enum for dataset data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> CreateDatasetAsync(
            string name,
            global::G.AnyOf<string, object>? description = default,
            global::System.DateTime? createdAt = default,
            global::G.AnyOf<object, object>? inputsSchemaDefinition = default,
            global::G.AnyOf<object, object>? outputsSchemaDefinition = default,
            global::G.AnyOf<bool?, object>? externallyManaged = default,
            global::G.AnyOf<global::System.Guid?, object>? id = default,
            global::G.AnyOf<object, object>? extra = default,
            global::G.DataType? dataType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
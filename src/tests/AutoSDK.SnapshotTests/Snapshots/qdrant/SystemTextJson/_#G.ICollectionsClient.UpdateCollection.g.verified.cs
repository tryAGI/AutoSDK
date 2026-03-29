//HintName: G.ICollectionsClient.UpdateCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Update collection parameters<br/>
        /// Update parameters of the existing collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionResponse> UpdateCollectionAsync(
            string collectionName,

            global::G.UpdateCollection request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection parameters<br/>
        /// Update parameters of the existing collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="vectors">
        /// Map of vector data parameters to update for each named vector. To update parameters in a collection having a single unnamed vector, use an empty string as name.
        /// </param>
        /// <param name="optimizersConfig">
        /// Custom params for Optimizers.  If none - it is left unchanged. This operation is blocking, it will only proceed once all current optimizations are complete
        /// </param>
        /// <param name="params">
        /// Collection base params. If none - it is left unchanged.
        /// </param>
        /// <param name="hnswConfig">
        /// HNSW parameters to update for the collection index. If none - it is left unchanged.
        /// </param>
        /// <param name="quantizationConfig">
        /// Quantization parameters to update. If none - it is left unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sparseVectors">
        /// Map of sparse vector data parameters to update for each sparse vector.
        /// </param>
        /// <param name="strictModeConfig"></param>
        /// <param name="metadata">
        /// Metadata to update for the collection. If provided, this will merge with existing metadata. To remove metadata, set it to an empty object.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionResponse> UpdateCollectionAsync(
            string collectionName,
            int? timeout = default,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorParamsDiff>? vectors = default,
            global::G.OptimizersConfigDiff? optimizersConfig = default,
            global::G.CollectionParamsDiff? @params = default,
            global::G.HnswConfigDiff? hnswConfig = default,
            global::G.QuantizationConfigDiff? quantizationConfig = default,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors = default,
            global::G.StrictModeConfig? strictModeConfig = default,
            global::G.Payload? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
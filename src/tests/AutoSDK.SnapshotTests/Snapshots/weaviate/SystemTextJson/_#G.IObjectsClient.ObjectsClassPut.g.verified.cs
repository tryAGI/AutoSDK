//HintName: G.IObjectsClient.ObjectsClassPut.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Update an object.<br/>
        /// Update an object based on its uuid and collection. This (`put`) method replaces the object with the provided object.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Object> ObjectsClassPutAsync(
            string className,
            global::System.Guid id,
            global::G.Object request,
            global::G.ObjectsClassPutConsistencyLevel? consistencyLevel = global::G.ObjectsClassPutConsistencyLevel.QUORUM,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an object.<br/>
        /// Update an object based on its uuid and collection. This (`put`) method replaces the object with the provided object.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="class">
        /// The object collection name.
        /// </param>
        /// <param name="vectorWeights">
        /// Allow custom overrides of vector weights as math expressions in word-based vectorization models. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word.
        /// </param>
        /// <param name="properties">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="requestId">
        /// ID of the object.
        /// </param>
        /// <param name="creationTimeUnix">
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </param>
        /// <param name="lastUpdateTimeUnix">
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </param>
        /// <param name="vector">
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </param>
        /// <param name="vectors">
        /// A map of named vectors for multi-vector representations.
        /// </param>
        /// <param name="tenant">
        /// Name of the tenant.
        /// </param>
        /// <param name="additional">
        /// (Response only) Additional meta information about a single object.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Object> ObjectsClassPutAsync(
            string className,
            global::System.Guid id,
            global::G.ObjectsClassPutConsistencyLevel? consistencyLevel = global::G.ObjectsClassPutConsistencyLevel.QUORUM,
            string? @class = default,
            global::G.VectorWeights? vectorWeights = default,
            global::G.PropertySchema? properties = default,
            global::System.Guid? requestId = default,
            long? creationTimeUnix = default,
            long? lastUpdateTimeUnix = default,
            global::System.Collections.Generic.IList<float>? vector = default,
            global::G.Vectors? vectors = default,
            string? tenant = default,
            global::G.AdditionalProperties? additional = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
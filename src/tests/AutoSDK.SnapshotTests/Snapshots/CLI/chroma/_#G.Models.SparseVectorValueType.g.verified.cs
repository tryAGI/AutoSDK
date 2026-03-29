//HintName: G.Models.SparseVectorValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sparse vector value type index configurations
    /// </summary>
    public sealed partial class SparseVectorValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vector_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.SparseVectorIndexType>))]
        public global::G.OneOf<object, global::G.SparseVectorIndexType>? SparseVectorIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorValueType" /> class.
        /// </summary>
        /// <param name="sparseVectorIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorValueType(
            global::G.OneOf<object, global::G.SparseVectorIndexType>? sparseVectorIndex)
        {
            this.SparseVectorIndex = sparseVectorIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorValueType" /> class.
        /// </summary>
        public SparseVectorValueType()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("sparse_vector_index")]
        public global::G.OneOf<object, global::G.SparseVectorIndexType>? SparseVectorIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorValueType" /> class.
        /// </summary>
        /// <param name="sparseVectorIndex"></param>
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
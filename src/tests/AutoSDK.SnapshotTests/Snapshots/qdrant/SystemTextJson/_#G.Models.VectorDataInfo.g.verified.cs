//HintName: G.Models.VectorDataInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorDataInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_indexed_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumIndexedVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDeletedVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorDataInfo" /> class.
        /// </summary>
        /// <param name="numVectors"></param>
        /// <param name="numIndexedVectors"></param>
        /// <param name="numDeletedVectors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorDataInfo(
            int numVectors,
            int numIndexedVectors,
            int numDeletedVectors)
        {
            this.NumVectors = numVectors;
            this.NumIndexedVectors = numIndexedVectors;
            this.NumDeletedVectors = numDeletedVectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorDataInfo" /> class.
        /// </summary>
        public VectorDataInfo()
        {
        }
    }
}
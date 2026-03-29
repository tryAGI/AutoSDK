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
        [global::Newtonsoft.Json.JsonProperty("num_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumVectors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_indexed_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumIndexedVectors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_deleted_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumDeletedVectors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorDataInfo" /> class.
        /// </summary>
        /// <param name="numVectors"></param>
        /// <param name="numIndexedVectors"></param>
        /// <param name="numDeletedVectors"></param>
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
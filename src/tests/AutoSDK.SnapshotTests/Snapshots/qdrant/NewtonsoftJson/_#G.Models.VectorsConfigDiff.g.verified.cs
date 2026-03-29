//HintName: G.Models.VectorsConfigDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector update params for multiple vectors<br/>
    /// { "vector_name": { "hnsw_config": { "m": 8 } } }
    /// </summary>
    public sealed partial class VectorsConfigDiff
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
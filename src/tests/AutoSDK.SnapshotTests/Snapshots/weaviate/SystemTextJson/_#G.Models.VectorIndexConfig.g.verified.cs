//HintName: G.Models.VectorIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
    /// </summary>
    public sealed partial class VectorIndexConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VectorIndexConfig(
 )
        {
        }
    }
}
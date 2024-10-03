//HintName: G.Models.ClassVectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
    /// </summary>
    public sealed partial class ClassVectorConfig
    {
        /// <summary>
        /// Configuration of each named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("<vector_name>")]
        public global::G.VectorConfig? x_vectorName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
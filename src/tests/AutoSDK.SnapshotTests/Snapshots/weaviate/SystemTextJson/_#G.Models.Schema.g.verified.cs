//HintName: G.Models.Schema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Definitions of semantic schemas (also see: https://github.com/weaviate/weaviate-semantic-schemas).
    /// </summary>
    public sealed partial class Schema
    {
        /// <summary>
        /// Semantic classes that are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<global::G.Class>? Classes { get; set; }

        /// <summary>
        /// Email of the maintainer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainer")]
        public string? Maintainer { get; set; }

        /// <summary>
        /// Name of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
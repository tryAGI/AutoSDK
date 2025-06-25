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

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        /// <param name="classes">
        /// Semantic classes that are available.
        /// </param>
        /// <param name="maintainer">
        /// Email of the maintainer.
        /// </param>
        /// <param name="name">
        /// Name of the schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Schema(
            global::System.Collections.Generic.IList<global::G.Class>? classes,
            string? maintainer,
            string? name)
        {
            this.Classes = classes;
            this.Maintainer = maintainer;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        public Schema()
        {
        }
    }
}
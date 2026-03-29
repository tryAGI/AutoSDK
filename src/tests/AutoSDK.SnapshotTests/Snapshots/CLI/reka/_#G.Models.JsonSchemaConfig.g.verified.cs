//HintName: G.Models.JsonSchemaConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema configuration for structured output.
    /// </summary>
    public sealed partial class JsonSchemaConfig
    {
        /// <summary>
        /// Name for the schema. Alphanumeric with underscores/dashes, max 64 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the expected output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Valid JSON Schema defining the expected structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Whether to enforce exact schema compliance.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the schema. Alphanumeric with underscores/dashes, max 64 characters.
        /// </param>
        /// <param name="schema">
        /// Valid JSON Schema defining the expected structure.
        /// </param>
        /// <param name="description">
        /// Description of the expected output format.
        /// </param>
        /// <param name="strict">
        /// Whether to enforce exact schema compliance.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaConfig(
            string name,
            object schema,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaConfig" /> class.
        /// </summary>
        public JsonSchemaConfig()
        {
        }
    }
}
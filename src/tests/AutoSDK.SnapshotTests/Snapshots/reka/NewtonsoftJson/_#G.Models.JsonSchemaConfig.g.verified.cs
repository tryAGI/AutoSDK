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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the expected output format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Valid JSON Schema defining the expected structure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Whether to enforce exact schema compliance.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
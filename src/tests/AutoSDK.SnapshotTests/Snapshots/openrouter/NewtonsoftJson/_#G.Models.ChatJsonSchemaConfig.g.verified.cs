//HintName: G.Models.ChatJsonSchemaConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema configuration object
    /// </summary>
    public sealed partial class ChatJsonSchemaConfig
    {
        /// <summary>
        /// Schema name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Schema description for the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Enable strict schema adherence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatJsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// Schema name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)
        /// </param>
        /// <param name="description">
        /// Schema description for the model
        /// </param>
        /// <param name="schema">
        /// JSON Schema object
        /// </param>
        /// <param name="strict">
        /// Enable strict schema adherence
        /// </param>
        public ChatJsonSchemaConfig(
            string name,
            string? description,
            object? schema,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatJsonSchemaConfig" /> class.
        /// </summary>
        public ChatJsonSchemaConfig()
        {
        }
    }
}
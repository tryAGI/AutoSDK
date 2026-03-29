//HintName: G.Models.ChatFormatJsonSchemaConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema response format for structured outputs
    /// </summary>
    public sealed partial class ChatFormatJsonSchemaConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatFormatJsonSchemaConfigTypeJsonConverter))]
        public global::G.ChatFormatJsonSchemaConfigType Type { get; set; }

        /// <summary>
        /// JSON Schema configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatJsonSchemaConfig JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// JSON Schema configuration object
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFormatJsonSchemaConfig(
            global::G.ChatJsonSchemaConfig jsonSchema,
            global::G.ChatFormatJsonSchemaConfigType type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonSchemaConfig" /> class.
        /// </summary>
        public ChatFormatJsonSchemaConfig()
        {
        }
    }
}
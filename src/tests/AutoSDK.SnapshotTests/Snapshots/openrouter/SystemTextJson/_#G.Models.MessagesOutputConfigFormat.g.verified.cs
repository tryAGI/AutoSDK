//HintName: G.Models.MessagesOutputConfigFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
    /// </summary>
    public sealed partial class MessagesOutputConfigFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter))]
        public global::G.MessagesOutputConfigFormatType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigFormat" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesOutputConfigFormat(
            object schema,
            global::G.MessagesOutputConfigFormatType type)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigFormat" /> class.
        /// </summary>
        public MessagesOutputConfigFormat()
        {
        }
    }
}
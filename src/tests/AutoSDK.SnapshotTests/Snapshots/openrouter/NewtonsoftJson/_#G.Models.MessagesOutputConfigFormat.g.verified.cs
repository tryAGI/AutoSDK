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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter))]
        public global::G.MessagesOutputConfigFormatType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigFormat" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="type"></param>
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
//HintName: G.Models.ChatStreamEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The streamed event types
    /// </summary>
    public sealed partial class ChatStreamEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatStreamEventTypeType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventType" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ChatStreamEventType(
            global::G.ChatStreamEventTypeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventType" /> class.
        /// </summary>
        public ChatStreamEventType()
        {
        }
    }
}
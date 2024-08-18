//HintName: G.Models.MessageStreamEventVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
    /// </summary>
    public sealed partial class MessageStreamEventVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.MessageStreamEventVariant3Event Event { get; set; }

        /// <summary>
        /// Represents a message delta i.e. any changed fields on a message during streaming.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
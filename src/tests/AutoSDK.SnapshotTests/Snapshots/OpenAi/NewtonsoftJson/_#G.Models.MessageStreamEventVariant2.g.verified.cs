//HintName: G.Models.MessageStreamEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [message](/docs/api-reference/messages/object) moves to an `in_progress` state.
    /// </summary>
    public sealed partial class MessageStreamEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.MessageStreamEventVariant2Event Event { get; set; }

        /// <summary>
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.MessageStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [message](/docs/api-reference/messages/object) is created.
    /// </summary>
    public sealed partial class MessageStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventVariant1Event Event { get; set; } = default!;

        /// <summary>
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObject? Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
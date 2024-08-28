//HintName: G.Models.ChatMessageStartEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventVariant2DeltaMessage
    {
        /// <summary>
        /// The role of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatMessageStartEventVariant2DeltaMessageRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
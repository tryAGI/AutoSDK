//HintName: G.Models.StreamedChatResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamedChatResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.StreamedChatResponseDiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedChatResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        public StreamedChatResponseDiscriminator(
            global::G.StreamedChatResponseDiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedChatResponseDiscriminator" /> class.
        /// </summary>
        public StreamedChatResponseDiscriminator()
        {
        }
    }
}
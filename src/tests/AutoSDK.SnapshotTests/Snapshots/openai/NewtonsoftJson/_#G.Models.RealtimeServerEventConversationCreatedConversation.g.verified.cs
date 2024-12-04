//HintName: G.Models.RealtimeServerEventConversationCreatedConversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The conversation resource.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationCreatedConversation
    {
        /// <summary>
        /// The unique ID of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, must be `realtime.conversation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreatedConversation" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation.
        /// </param>
        /// <param name="object">
        /// The object type, must be `realtime.conversation`.
        /// </param>
        public RealtimeServerEventConversationCreatedConversation(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreatedConversation" /> class.
        /// </summary>
        public RealtimeServerEventConversationCreatedConversation()
        {
        }
    }
}
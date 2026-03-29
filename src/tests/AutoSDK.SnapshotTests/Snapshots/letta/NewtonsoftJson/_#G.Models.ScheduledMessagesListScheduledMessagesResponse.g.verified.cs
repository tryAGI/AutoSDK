//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduled_messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessage> ScheduledMessages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponse" /> class.
        /// </summary>
        /// <param name="scheduledMessages"></param>
        /// <param name="hasNextPage"></param>
        public ScheduledMessagesListScheduledMessagesResponse(
            global::System.Collections.Generic.IList<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessage> scheduledMessages,
            bool hasNextPage)
        {
            this.ScheduledMessages = scheduledMessages ?? throw new global::System.ArgumentNullException(nameof(scheduledMessages));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponse" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponse()
        {
        }
    }
}
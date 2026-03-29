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
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessage> ScheduledMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponse" /> class.
        /// </summary>
        /// <param name="scheduledMessages"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
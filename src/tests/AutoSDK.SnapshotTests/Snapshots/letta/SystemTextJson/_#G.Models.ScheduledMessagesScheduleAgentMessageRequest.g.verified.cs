//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScheduledMessagesScheduleAgentMessageRequestMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_steps")]
        public double? MaxSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_return_message_types")]
        public global::System.Collections.Generic.IList<global::G.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType>? IncludeReturnMessageTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2> Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="schedule"></param>
        /// <param name="maxSteps"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="includeReturnMessageTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesScheduleAgentMessageRequest(
            global::System.Collections.Generic.IList<global::G.ScheduledMessagesScheduleAgentMessageRequestMessage> messages,
            global::G.OneOf<global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2> schedule,
            double? maxSteps,
            string? callbackUrl,
            global::System.Collections.Generic.IList<global::G.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType>? includeReturnMessageTypes)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxSteps = maxSteps;
            this.CallbackUrl = callbackUrl;
            this.IncludeReturnMessageTypes = includeReturnMessageTypes;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequest" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequest()
        {
        }
    }
}
//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesRetrieveScheduledMessageResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_steps")]
        public double? MaxSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_return_message_types")]
        public global::System.Collections.Generic.IList<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType>? IncludeReturnMessageTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessage" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="maxSteps"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="includeReturnMessageTypes"></param>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessage(
            global::System.Collections.Generic.IList<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage> messages,
            double? maxSteps,
            string? callbackUrl,
            global::System.Collections.Generic.IList<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType>? includeReturnMessageTypes)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxSteps = maxSteps;
            this.CallbackUrl = callbackUrl;
            this.IncludeReturnMessageTypes = includeReturnMessageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessage" /> class.
        /// </summary>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessage()
        {
        }
    }
}
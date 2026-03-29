//HintName: G.Models.ClientInboundMessageSay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageSay
    {
        /// <summary>
        /// This is the type of the message. Send "say" message to make the assistant say something.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClientInboundMessageSayType? Type { get; set; }

        /// <summary>
        /// This is the flag for whether the message should replace existing assistant speech.<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruptAssistantEnabled")]
        public bool? InterruptAssistantEnabled { get; set; }

        /// <summary>
        /// This is the content to say.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This is the flag to end call after content is spoken.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endCallAfterSpoken")]
        public bool? EndCallAfterSpoken { get; set; }

        /// <summary>
        /// This is the flag for whether the message is interruptible by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruptionsEnabled")]
        public bool? InterruptionsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSay" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the message. Send "say" message to make the assistant say something.
        /// </param>
        /// <param name="interruptAssistantEnabled">
        /// This is the flag for whether the message should replace existing assistant speech.<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="content">
        /// This is the content to say.
        /// </param>
        /// <param name="endCallAfterSpoken">
        /// This is the flag to end call after content is spoken.
        /// </param>
        /// <param name="interruptionsEnabled">
        /// This is the flag for whether the message is interruptible by the user.
        /// </param>
        public ClientInboundMessageSay(
            global::G.ClientInboundMessageSayType? type,
            bool? interruptAssistantEnabled,
            string? content,
            bool? endCallAfterSpoken,
            bool? interruptionsEnabled)
        {
            this.Type = type;
            this.InterruptAssistantEnabled = interruptAssistantEnabled;
            this.Content = content;
            this.EndCallAfterSpoken = endCallAfterSpoken;
            this.InterruptionsEnabled = interruptionsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSay" /> class.
        /// </summary>
        public ClientInboundMessageSay()
        {
        }
    }
}
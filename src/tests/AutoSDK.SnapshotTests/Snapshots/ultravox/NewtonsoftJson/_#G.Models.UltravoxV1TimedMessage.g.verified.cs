//HintName: G.Models.UltravoxV1TimedMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message the agent should say after some duration. The duration's meaning<br/>
    ///  varies depending on the context.
    /// </summary>
    public sealed partial class UltravoxV1TimedMessage
    {
        /// <summary>
        /// The duration after which the message should be spoken.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// The message to speak.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The behavior to exhibit when the message is finished being spoken.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endBehavior")]
        public global::G.UltravoxV1TimedMessageEndBehavior? EndBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TimedMessage" /> class.
        /// </summary>
        /// <param name="duration">
        /// The duration after which the message should be spoken.
        /// </param>
        /// <param name="message">
        /// The message to speak.
        /// </param>
        /// <param name="endBehavior">
        /// The behavior to exhibit when the message is finished being spoken.
        /// </param>
        public UltravoxV1TimedMessage(
            string? duration,
            string? message,
            global::G.UltravoxV1TimedMessageEndBehavior? endBehavior)
        {
            this.Duration = duration;
            this.Message = message;
            this.EndBehavior = endBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TimedMessage" /> class.
        /// </summary>
        public UltravoxV1TimedMessage()
        {
        }
    }
}
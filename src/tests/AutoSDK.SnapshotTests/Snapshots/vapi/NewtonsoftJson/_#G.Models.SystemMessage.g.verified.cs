//HintName: G.Models.SystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemMessage
    {
        /// <summary>
        /// The role of the system in the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The message content from the system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secondsFromStart", Required = global::Newtonsoft.Json.Required.Always)]
        public double SecondsFromStart { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the system in the conversation.
        /// </param>
        /// <param name="message">
        /// The message content from the system.
        /// </param>
        /// <param name="time">
        /// The timestamp when the message was sent.
        /// </param>
        /// <param name="secondsFromStart">
        /// The number of seconds from the start of the conversation.
        /// </param>
        public SystemMessage(
            string role,
            string message,
            double time,
            double secondsFromStart)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Time = time;
            this.SecondsFromStart = secondsFromStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        public SystemMessage()
        {
        }
    }
}
//HintName: G.Models.BotMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BotMessage
    {
        /// <summary>
        /// The role of the bot in the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The message content from the bot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// The timestamp when the message ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secondsFromStart", Required = global::Newtonsoft.Json.Required.Always)]
        public double SecondsFromStart { get; set; } = default!;

        /// <summary>
        /// The source of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The duration of the message in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the bot in the conversation.
        /// </param>
        /// <param name="message">
        /// The message content from the bot.
        /// </param>
        /// <param name="time">
        /// The timestamp when the message was sent.
        /// </param>
        /// <param name="endTime">
        /// The timestamp when the message ended.
        /// </param>
        /// <param name="secondsFromStart">
        /// The number of seconds from the start of the conversation.
        /// </param>
        /// <param name="source">
        /// The source of the message.
        /// </param>
        /// <param name="duration">
        /// The duration of the message in seconds.
        /// </param>
        public BotMessage(
            string role,
            string message,
            double time,
            double endTime,
            double secondsFromStart,
            string? source,
            double? duration)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Time = time;
            this.EndTime = endTime;
            this.SecondsFromStart = secondsFromStart;
            this.Source = source;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotMessage" /> class.
        /// </summary>
        public BotMessage()
        {
        }
    }
}
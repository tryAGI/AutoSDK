//HintName: G.Models.UserMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMessage
    {
        /// <summary>
        /// The role of the user in the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The message content from the user.
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
        /// The duration of the message in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Indicates if the message was filtered for security reasons.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the message was filtered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original message before filtering (only included if content was filtered).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalMessage")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakerLabel")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the user in the conversation.
        /// </param>
        /// <param name="message">
        /// The message content from the user.
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
        /// <param name="duration">
        /// The duration of the message in seconds.
        /// </param>
        /// <param name="isFiltered">
        /// Indicates if the message was filtered for security reasons.
        /// </param>
        /// <param name="detectedThreats">
        /// List of detected security threats if the message was filtered.
        /// </param>
        /// <param name="originalMessage">
        /// The original message before filtering (only included if content was filtered).
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
        /// </param>
        /// <param name="speakerLabel">
        /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
        /// </param>
        public UserMessage(
            string role,
            string message,
            double time,
            double endTime,
            double secondsFromStart,
            double? duration,
            bool? isFiltered,
            global::System.Collections.Generic.IList<string>? detectedThreats,
            string? originalMessage,
            object? metadata,
            string? speakerLabel)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Time = time;
            this.EndTime = endTime;
            this.SecondsFromStart = secondsFromStart;
            this.Duration = duration;
            this.IsFiltered = isFiltered;
            this.DetectedThreats = detectedThreats;
            this.OriginalMessage = originalMessage;
            this.Metadata = metadata;
            this.SpeakerLabel = speakerLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        public UserMessage()
        {
        }
    }
}
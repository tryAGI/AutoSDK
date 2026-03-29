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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The message content from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// The timestamp when the message ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondsFromStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SecondsFromStart { get; set; }

        /// <summary>
        /// The duration of the message in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Indicates if the message was filtered for security reasons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the message was filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original message before filtering (only included if content was filtered).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalMessage")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakerLabel")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
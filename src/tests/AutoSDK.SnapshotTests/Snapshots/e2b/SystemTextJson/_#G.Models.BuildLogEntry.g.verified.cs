//HintName: G.Models.BuildLogEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildLogEntry
    {
        /// <summary>
        /// Timestamp of the log entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Log message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// State of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LogLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LogLevel Level { get; set; }

        /// <summary>
        /// Step in the build process related to the log entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogEntry" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the log entry
        /// </param>
        /// <param name="message">
        /// Log message content
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="step">
        /// Step in the build process related to the log entry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildLogEntry(
            global::System.DateTime timestamp,
            string message,
            global::G.LogLevel level,
            string? step)
        {
            this.Timestamp = timestamp;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Level = level;
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogEntry" /> class.
        /// </summary>
        public BuildLogEntry()
        {
        }
    }
}
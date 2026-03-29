//HintName: G.Models.SandboxLogEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxLogEntry
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogEntry" /> class.
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
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLogEntry(
            global::System.DateTime timestamp,
            string message,
            global::G.LogLevel level,
            global::System.Collections.Generic.Dictionary<string, string> fields)
        {
            this.Timestamp = timestamp;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Level = level;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogEntry" /> class.
        /// </summary>
        public SandboxLogEntry()
        {
        }
    }
}
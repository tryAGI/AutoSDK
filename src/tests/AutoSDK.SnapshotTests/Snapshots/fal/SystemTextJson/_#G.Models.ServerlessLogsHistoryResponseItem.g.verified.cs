//HintName: G.Models.ServerlessLogsHistoryResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single log entry
    /// </summary>
    public sealed partial class ServerlessLogsHistoryResponseItem
    {
        /// <summary>
        /// ISO timestamp of the log line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Log level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Level { get; set; }

        /// <summary>
        /// Log message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// App identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string App { get; set; }

        /// <summary>
        /// Revision identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Revision { get; set; }

        /// <summary>
        /// Additional labels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessLogsHistoryResponseItem" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// ISO timestamp of the log line
        /// </param>
        /// <param name="level">
        /// Log level
        /// </param>
        /// <param name="message">
        /// Log message
        /// </param>
        /// <param name="app">
        /// App identifier
        /// </param>
        /// <param name="revision">
        /// Revision identifier
        /// </param>
        /// <param name="labels">
        /// Additional labels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessLogsHistoryResponseItem(
            string timestamp,
            string level,
            string message,
            string app,
            string revision,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Level = level ?? throw new global::System.ArgumentNullException(nameof(level));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Revision = revision ?? throw new global::System.ArgumentNullException(nameof(revision));
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessLogsHistoryResponseItem" /> class.
        /// </summary>
        public ServerlessLogsHistoryResponseItem()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Log level
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public string Level { get; set; } = default!;

        /// <summary>
        /// Log message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// App identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public string App { get; set; } = default!;

        /// <summary>
        /// Revision identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("revision", Required = global::Newtonsoft.Json.Required.Always)]
        public string Revision { get; set; } = default!;

        /// <summary>
        /// Additional labels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
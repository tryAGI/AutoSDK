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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Log message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// State of the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LogLevelJsonConverter))]
        public global::G.LogLevel Level { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
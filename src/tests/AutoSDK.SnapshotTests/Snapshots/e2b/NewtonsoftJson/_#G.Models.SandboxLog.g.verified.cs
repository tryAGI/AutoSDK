//HintName: G.Models.SandboxLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log entry with timestamp and line
    /// </summary>
    public sealed partial class SandboxLog
    {
        /// <summary>
        /// Timestamp of the log entry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Log line content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line", Required = global::Newtonsoft.Json.Required.Always)]
        public string Line { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLog" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the log entry
        /// </param>
        /// <param name="line">
        /// Log line content
        /// </param>
        public SandboxLog(
            global::System.DateTime timestamp,
            string line)
        {
            this.Timestamp = timestamp;
            this.Line = line ?? throw new global::System.ArgumentNullException(nameof(line));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLog" /> class.
        /// </summary>
        public SandboxLog()
        {
        }
    }
}
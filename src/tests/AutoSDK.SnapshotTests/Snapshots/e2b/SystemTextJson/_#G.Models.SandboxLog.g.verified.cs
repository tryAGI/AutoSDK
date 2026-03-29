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
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Log line content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
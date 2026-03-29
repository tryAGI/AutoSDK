//HintName: G.Models.SandboxLogs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxLogs
    {
        /// <summary>
        /// Logs of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SandboxLog> Logs { get; set; }

        /// <summary>
        /// Structured logs of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logEntries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SandboxLogEntry> LogEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogs" /> class.
        /// </summary>
        /// <param name="logs">
        /// Logs of the sandbox
        /// </param>
        /// <param name="logEntries">
        /// Structured logs of the sandbox
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLogs(
            global::System.Collections.Generic.IList<global::G.SandboxLog> logs,
            global::System.Collections.Generic.IList<global::G.SandboxLogEntry> logEntries)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.LogEntries = logEntries ?? throw new global::System.ArgumentNullException(nameof(logEntries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogs" /> class.
        /// </summary>
        public SandboxLogs()
        {
        }
    }
}
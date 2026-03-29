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
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SandboxLog> Logs { get; set; } = default!;

        /// <summary>
        /// Structured logs of the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logEntries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SandboxLogEntry> LogEntries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
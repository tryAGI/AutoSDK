//HintName: G.Models.ToolExecutionResult.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolExecutionResult
    {
        /// <summary>
        /// The status of the tool execution and return object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolExecutionResultStatus Status { get; set; } = default!;

        /// <summary>
        /// The function return object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("func_return")]
        public object? FuncReturn { get; set; }

        /// <summary>
        /// The agent state
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_state")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.AgentState? AgentState { get; set; }

        /// <summary>
        /// Captured stdout (prints, logs) from function invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// Captured stderr from the function invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// The fingerprint of the config for the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandbox_config_fingerprint")]
        public string? SandboxConfigFingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionResult" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the tool execution and return object
        /// </param>
        /// <param name="funcReturn">
        /// The function return object
        /// </param>
        /// <param name="stdout">
        /// Captured stdout (prints, logs) from function invocation
        /// </param>
        /// <param name="stderr">
        /// Captured stderr from the function invocation
        /// </param>
        /// <param name="sandboxConfigFingerprint">
        /// The fingerprint of the config for the sandbox
        /// </param>
        public ToolExecutionResult(
            global::G.ToolExecutionResultStatus status,
            object? funcReturn,
            global::System.Collections.Generic.IList<string>? stdout,
            global::System.Collections.Generic.IList<string>? stderr,
            string? sandboxConfigFingerprint)
        {
            this.Status = status;
            this.FuncReturn = funcReturn;
            this.Stdout = stdout;
            this.Stderr = stderr;
            this.SandboxConfigFingerprint = sandboxConfigFingerprint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionResult" /> class.
        /// </summary>
        public ToolExecutionResult()
        {
        }
    }
}
//HintName: G.Models.SandboxLogsV2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxLogsV2Response
    {
        /// <summary>
        /// Sandbox logs structured<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SandboxLogEntry> Logs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogsV2Response" /> class.
        /// </summary>
        /// <param name="logs">
        /// Sandbox logs structured<br/>
        /// Default Value: []
        /// </param>
        public SandboxLogsV2Response(
            global::System.Collections.Generic.IList<global::G.SandboxLogEntry> logs)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogsV2Response" /> class.
        /// </summary>
        public SandboxLogsV2Response()
        {
        }
    }
}
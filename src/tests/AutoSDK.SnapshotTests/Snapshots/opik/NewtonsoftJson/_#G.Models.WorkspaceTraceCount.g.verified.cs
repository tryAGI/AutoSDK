//HintName: G.Models.WorkspaceTraceCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceTraceCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace")]
        public string? Workspace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_count")]
        public int? TraceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceTraceCount" /> class.
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="traceCount"></param>
        public WorkspaceTraceCount(
            string? workspace,
            int? traceCount)
        {
            this.Workspace = workspace;
            this.TraceCount = traceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceTraceCount" /> class.
        /// </summary>
        public WorkspaceTraceCount()
        {
        }
    }
}
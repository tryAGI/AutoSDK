//HintName: G.Models.TraceCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces_traces_count")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceTraceCount>? WorkspacesTracesCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCountResponse" /> class.
        /// </summary>
        /// <param name="workspacesTracesCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceCountResponse(
            global::System.Collections.Generic.IList<global::G.WorkspaceTraceCount>? workspacesTracesCount)
        {
            this.WorkspacesTracesCount = workspacesTracesCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCountResponse" /> class.
        /// </summary>
        public TraceCountResponse()
        {
        }
    }
}
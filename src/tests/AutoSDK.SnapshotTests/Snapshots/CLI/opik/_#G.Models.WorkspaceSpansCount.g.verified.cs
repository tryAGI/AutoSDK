//HintName: G.Models.WorkspaceSpansCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceSpansCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public string? Workspace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_count")]
        public int? SpanCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSpansCount" /> class.
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="spanCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceSpansCount(
            string? workspace,
            int? spanCount)
        {
            this.Workspace = workspace;
            this.SpanCount = spanCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSpansCount" /> class.
        /// </summary>
        public WorkspaceSpansCount()
        {
        }
    }
}
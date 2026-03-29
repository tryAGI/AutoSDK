//HintName: G.Models.SpansCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpansCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces_spans_count")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceSpansCount>? WorkspacesSpansCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpansCountResponse" /> class.
        /// </summary>
        /// <param name="workspacesSpansCount"></param>
        public SpansCountResponse(
            global::System.Collections.Generic.IList<global::G.WorkspaceSpansCount>? workspacesSpansCount)
        {
            this.WorkspacesSpansCount = workspacesSpansCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpansCountResponse" /> class.
        /// </summary>
        public SpansCountResponse()
        {
        }
    }
}
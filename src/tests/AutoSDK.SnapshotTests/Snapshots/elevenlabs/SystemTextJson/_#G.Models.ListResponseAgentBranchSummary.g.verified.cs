//HintName: G.Models.ListResponseAgentBranchSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResponseAgentBranchSummary
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ListResponseMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentBranchSummary> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseAgentBranchSummary" /> class.
        /// </summary>
        /// <param name="meta">
        /// Default Value: {}
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResponseAgentBranchSummary(
            global::System.Collections.Generic.IList<global::G.AgentBranchSummary> results,
            global::G.ListResponseMeta? meta)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseAgentBranchSummary" /> class.
        /// </summary>
        public ListResponseAgentBranchSummary()
        {
        }
    }
}
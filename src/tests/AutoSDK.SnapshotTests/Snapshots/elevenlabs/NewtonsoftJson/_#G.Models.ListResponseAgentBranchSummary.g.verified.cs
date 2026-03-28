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
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ListResponseMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentBranchSummary> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseAgentBranchSummary" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="meta">
        /// Default Value: {}
        /// </param>
        public ListResponseAgentBranchSummary(
            global::System.Collections.Generic.IList<global::G.AgentBranchSummary> results,
            global::G.ListResponseMeta? meta)
        {
            this.Meta = meta;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseAgentBranchSummary" /> class.
        /// </summary>
        public ListResponseAgentBranchSummary()
        {
        }
    }
}
//HintName: G.Models.GetToolDependentAgentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolDependentAgentsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentsItem3> Agents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branches")]
        public global::System.Collections.Generic.IList<global::G.DependentBranchInfo>? Branches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModel" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="hasMore"></param>
        /// <param name="branches"></param>
        /// <param name="nextCursor"></param>
        public GetToolDependentAgentsResponseModel(
            global::System.Collections.Generic.IList<global::G.AgentsItem3> agents,
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.DependentBranchInfo>? branches,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Branches = branches;
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModel" /> class.
        /// </summary>
        public GetToolDependentAgentsResponseModel()
        {
        }
    }
}
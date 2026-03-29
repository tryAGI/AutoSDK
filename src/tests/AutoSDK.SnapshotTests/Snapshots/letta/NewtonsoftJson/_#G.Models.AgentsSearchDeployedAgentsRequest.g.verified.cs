//HintName: G.Models.AgentsSearchDeployedAgentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>? Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("combinator")]
        public global::G.AgentsSearchDeployedAgentsRequestCombinator? Combinator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after")]
        public string? After { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortBy")]
        public global::G.AgentsSearchDeployedAgentsRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ascending")]
        public bool? Ascending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequest" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="sortBy"></param>
        /// <param name="ascending"></param>
        public AgentsSearchDeployedAgentsRequest(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>? search,
            string? projectId,
            global::G.AgentsSearchDeployedAgentsRequestCombinator? combinator,
            double? limit,
            string? after,
            global::G.AgentsSearchDeployedAgentsRequestSortBy? sortBy,
            bool? ascending)
        {
            this.Search = search;
            this.ProjectId = projectId;
            this.Combinator = combinator;
            this.Limit = limit;
            this.After = after;
            this.SortBy = sortBy;
            this.Ascending = ascending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequest" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequest()
        {
        }
    }
}
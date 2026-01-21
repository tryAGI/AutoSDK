//HintName: G.Models.GetAgentsPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"has_more":false,"next_cursor":"123"}
    /// </summary>
    public sealed partial class GetAgentsPageResponseModel
    {
        /// <summary>
        /// A list of agents and their metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentSummaryResponseModel> Agents { get; set; } = default!;

        /// <summary>
        /// The next cursor to paginate through the agents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more agents to paginate through
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsPageResponseModel" /> class.
        /// </summary>
        /// <param name="agents">
        /// A list of agents and their metadata
        /// </param>
        /// <param name="nextCursor">
        /// The next cursor to paginate through the agents
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more agents to paginate through
        /// </param>
        public GetAgentsPageResponseModel(
            global::System.Collections.Generic.IList<global::G.AgentSummaryResponseModel> agents,
            bool hasMore,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsPageResponseModel" /> class.
        /// </summary>
        public GetAgentsPageResponseModel()
        {
        }
    }
}
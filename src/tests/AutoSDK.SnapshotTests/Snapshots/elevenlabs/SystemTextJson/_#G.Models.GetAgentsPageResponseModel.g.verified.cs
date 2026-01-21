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
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentSummaryResponseModel> Agents { get; set; }

        /// <summary>
        /// The next cursor to paginate through the agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more agents to paginate through
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
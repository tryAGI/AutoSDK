//HintName: G.Models.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
        public GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator(
            global::G.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator" /> class.
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator()
        {
        }
    }
}
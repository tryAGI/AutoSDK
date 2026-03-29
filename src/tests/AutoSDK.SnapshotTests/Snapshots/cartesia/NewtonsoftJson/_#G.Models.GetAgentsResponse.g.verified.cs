//HintName: G.Models.GetAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentsResponse
    {
        /// <summary>
        /// The summaries of the agents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summaries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentSummary> Summaries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsResponse" /> class.
        /// </summary>
        /// <param name="summaries">
        /// The summaries of the agents.
        /// </param>
        public GetAgentsResponse(
            global::System.Collections.Generic.IList<global::G.AgentSummary> summaries)
        {
            this.Summaries = summaries ?? throw new global::System.ArgumentNullException(nameof(summaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsResponse" /> class.
        /// </summary>
        public GetAgentsResponse()
        {
        }
    }
}
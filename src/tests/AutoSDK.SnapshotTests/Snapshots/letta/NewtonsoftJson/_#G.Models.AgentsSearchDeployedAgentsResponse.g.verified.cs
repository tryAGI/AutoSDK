//HintName: G.Models.AgentsSearchDeployedAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentState> Agents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="nextCursor"></param>
        public AgentsSearchDeployedAgentsResponse(
            global::System.Collections.Generic.IList<global::G.AgentState> agents,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsResponse" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsResponse()
        {
        }
    }
}
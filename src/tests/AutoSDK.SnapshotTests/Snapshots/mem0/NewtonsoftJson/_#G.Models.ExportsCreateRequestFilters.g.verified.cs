//HintName: G.Models.ExportsCreateRequestFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id.
    /// </summary>
    public sealed partial class ExportsCreateRequestFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequestFilters" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        public ExportsCreateRequestFilters(
            string? userId,
            string? agentId,
            string? appId,
            string? runId)
        {
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequestFilters" /> class.
        /// </summary>
        public ExportsCreateRequestFilters()
        {
        }
    }
}
//HintName: G.Models.DynamicManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicManager
    {
        /// <summary>
        /// Default Value: dynamic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManagerAgentId { get; set; } = default!;

        /// <summary>
        /// Default Value: DONE!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("termination_token")]
        public string? TerminationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicManager" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: dynamic
        /// </param>
        /// <param name="terminationToken">
        /// Default Value: DONE!
        /// </param>
        /// <param name="maxTurns"></param>
        public DynamicManager(
            string managerAgentId,
            string? managerType,
            string? terminationToken,
            int? maxTurns)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
            this.TerminationToken = terminationToken;
            this.MaxTurns = maxTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicManager" /> class.
        /// </summary>
        public DynamicManager()
        {
        }
    }
}
//HintName: G.Models.SupervisorManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupervisorManager
    {
        /// <summary>
        /// Default Value: supervisor
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManagerAgentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorManager" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: supervisor
        /// </param>
        public SupervisorManager(
            string managerAgentId,
            string? managerType)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorManager" /> class.
        /// </summary>
        public SupervisorManager()
        {
        }
    }
}
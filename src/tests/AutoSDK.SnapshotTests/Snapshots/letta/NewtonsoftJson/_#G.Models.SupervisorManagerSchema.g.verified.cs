//HintName: G.Models.SupervisorManagerSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupervisorManagerSchema
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
        /// Initializes a new instance of the <see cref="SupervisorManagerSchema" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: supervisor
        /// </param>
        public SupervisorManagerSchema(
            string managerAgentId,
            string? managerType)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorManagerSchema" /> class.
        /// </summary>
        public SupervisorManagerSchema()
        {
        }
    }
}
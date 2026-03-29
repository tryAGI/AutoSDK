//HintName: G.Models.SupervisorManagerUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupervisorManagerUpdate
    {
        /// <summary>
        /// Default Value: supervisor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorManagerUpdate" /> class.
        /// </summary>
        /// <param name="managerType">
        /// Default Value: supervisor
        /// </param>
        /// <param name="managerAgentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupervisorManagerUpdate(
            string? managerType,
            string? managerAgentId)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorManagerUpdate" /> class.
        /// </summary>
        public SupervisorManagerUpdate()
        {
        }
    }
}
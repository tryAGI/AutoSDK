//HintName: G.Models.SleeptimeManagerUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleeptimeManagerUpdate
    {
        /// <summary>
        /// Default Value: sleeptime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sleeptime_agent_frequency")]
        public int? SleeptimeAgentFrequency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleeptimeManagerUpdate" /> class.
        /// </summary>
        /// <param name="managerType">
        /// Default Value: sleeptime
        /// </param>
        /// <param name="managerAgentId"></param>
        /// <param name="sleeptimeAgentFrequency"></param>
        public SleeptimeManagerUpdate(
            string? managerType,
            string? managerAgentId,
            int? sleeptimeAgentFrequency)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId;
            this.SleeptimeAgentFrequency = sleeptimeAgentFrequency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleeptimeManagerUpdate" /> class.
        /// </summary>
        public SleeptimeManagerUpdate()
        {
        }
    }
}
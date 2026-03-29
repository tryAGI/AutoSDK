//HintName: G.Models.SleeptimeManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleeptimeManager
    {
        /// <summary>
        /// Default Value: sleeptime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManagerAgentId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="SleeptimeManager" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: sleeptime
        /// </param>
        /// <param name="sleeptimeAgentFrequency"></param>
        public SleeptimeManager(
            string managerAgentId,
            string? managerType,
            int? sleeptimeAgentFrequency)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
            this.SleeptimeAgentFrequency = sleeptimeAgentFrequency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleeptimeManager" /> class.
        /// </summary>
        public SleeptimeManager()
        {
        }
    }
}
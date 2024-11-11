//HintName: G.Models.EnvironmentProtectionRuleVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentProtectionRuleVariant1
    {
        /// <summary>
        /// Example: 3515
        /// </summary>
        /// <example>3515</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM1MTU=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: wait_timer
        /// </summary>
        /// <example>wait_timer</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("wait_timer")]
        public int? WaitTimer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3515
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </param>
        /// <param name="type">
        /// Example: wait_timer
        /// </param>
        /// <param name="waitTimer">
        /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).<br/>
        /// Example: 30
        /// </param>
        public EnvironmentProtectionRuleVariant1(
            int id,
            string nodeId,
            string type,
            int? waitTimer)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.WaitTimer = waitTimer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant1" /> class.
        /// </summary>
        public EnvironmentProtectionRuleVariant1()
        {
        }
    }
}
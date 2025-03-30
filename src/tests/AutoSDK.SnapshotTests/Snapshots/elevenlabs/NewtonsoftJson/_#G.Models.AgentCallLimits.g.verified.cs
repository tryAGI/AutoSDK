//HintName: G.Models.AgentCallLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCallLimits
    {
        /// <summary>
        /// The maximum number of concurrent conversations. -1 indicates that there is no maximum<br/>
        /// Default Value: -1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_concurrency_limit")]
        public int? AgentConcurrencyLimit { get; set; }

        /// <summary>
        /// The maximum number of conversations per day<br/>
        /// Default Value: 100000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("daily_limit")]
        public int? DailyLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallLimits" /> class.
        /// </summary>
        /// <param name="agentConcurrencyLimit">
        /// The maximum number of concurrent conversations. -1 indicates that there is no maximum<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="dailyLimit">
        /// The maximum number of conversations per day<br/>
        /// Default Value: 100000
        /// </param>
        public AgentCallLimits(
            int? agentConcurrencyLimit,
            int? dailyLimit)
        {
            this.AgentConcurrencyLimit = agentConcurrencyLimit;
            this.DailyLimit = dailyLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallLimits" /> class.
        /// </summary>
        public AgentCallLimits()
        {
        }
    }
}
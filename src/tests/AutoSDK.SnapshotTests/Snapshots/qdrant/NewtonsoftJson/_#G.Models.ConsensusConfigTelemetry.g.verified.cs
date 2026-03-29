//HintName: G.Models.ConsensusConfigTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_message_queue_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxMessageQueueSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tick_period_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int TickPeriodMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bootstrap_timeout_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public int BootstrapTimeoutSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusConfigTelemetry" /> class.
        /// </summary>
        /// <param name="maxMessageQueueSize"></param>
        /// <param name="tickPeriodMs"></param>
        /// <param name="bootstrapTimeoutSec"></param>
        public ConsensusConfigTelemetry(
            int maxMessageQueueSize,
            int tickPeriodMs,
            int bootstrapTimeoutSec)
        {
            this.MaxMessageQueueSize = maxMessageQueueSize;
            this.TickPeriodMs = tickPeriodMs;
            this.BootstrapTimeoutSec = bootstrapTimeoutSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusConfigTelemetry" /> class.
        /// </summary>
        public ConsensusConfigTelemetry()
        {
        }
    }
}
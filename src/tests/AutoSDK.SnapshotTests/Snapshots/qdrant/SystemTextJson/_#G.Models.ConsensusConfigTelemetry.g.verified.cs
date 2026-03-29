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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_message_queue_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMessageQueueSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tick_period_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TickPeriodMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootstrap_timeout_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BootstrapTimeoutSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusConfigTelemetry" /> class.
        /// </summary>
        /// <param name="maxMessageQueueSize"></param>
        /// <param name="tickPeriodMs"></param>
        /// <param name="bootstrapTimeoutSec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
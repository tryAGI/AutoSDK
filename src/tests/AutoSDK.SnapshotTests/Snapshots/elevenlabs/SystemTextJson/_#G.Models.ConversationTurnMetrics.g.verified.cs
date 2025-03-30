//HintName: G.Models.ConversationTurnMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTurnMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.Dictionary<string, global::G.MetricRecord>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurnMetrics" /> class.
        /// </summary>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTurnMetrics(
            global::System.Collections.Generic.Dictionary<string, global::G.MetricRecord>? metrics)
        {
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurnMetrics" /> class.
        /// </summary>
        public ConversationTurnMetrics()
        {
        }
    }
}
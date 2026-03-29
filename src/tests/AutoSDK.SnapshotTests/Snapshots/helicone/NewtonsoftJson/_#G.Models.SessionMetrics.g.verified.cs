//HintName: G.Models.SessionMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_count", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HistogramRow> SessionCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HistogramRow> SessionDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HistogramRow> SessionCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SessionMetricsAverage Average { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        /// <param name="sessionCount"></param>
        /// <param name="sessionDuration"></param>
        /// <param name="sessionCost"></param>
        /// <param name="average"></param>
        public SessionMetrics(
            global::System.Collections.Generic.IList<global::G.HistogramRow> sessionCount,
            global::System.Collections.Generic.IList<global::G.HistogramRow> sessionDuration,
            global::System.Collections.Generic.IList<global::G.HistogramRow> sessionCost,
            global::G.SessionMetricsAverage average)
        {
            this.SessionCount = sessionCount ?? throw new global::System.ArgumentNullException(nameof(sessionCount));
            this.SessionDuration = sessionDuration ?? throw new global::System.ArgumentNullException(nameof(sessionDuration));
            this.SessionCost = sessionCost ?? throw new global::System.ArgumentNullException(nameof(sessionCost));
            this.Average = average ?? throw new global::System.ArgumentNullException(nameof(average));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        public SessionMetrics()
        {
        }
    }
}
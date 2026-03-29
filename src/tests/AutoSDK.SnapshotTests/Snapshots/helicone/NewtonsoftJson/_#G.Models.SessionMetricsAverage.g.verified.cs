//HintName: G.Models.SessionMetricsAverage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionMetricsAverage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AverageRow> SessionCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AverageRow> SessionDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_count", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AverageRow> SessionCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsAverage" /> class.
        /// </summary>
        /// <param name="sessionCost"></param>
        /// <param name="sessionDuration"></param>
        /// <param name="sessionCount"></param>
        public SessionMetricsAverage(
            global::System.Collections.Generic.IList<global::G.AverageRow> sessionCost,
            global::System.Collections.Generic.IList<global::G.AverageRow> sessionDuration,
            global::System.Collections.Generic.IList<global::G.AverageRow> sessionCount)
        {
            this.SessionCost = sessionCost ?? throw new global::System.ArgumentNullException(nameof(sessionCost));
            this.SessionDuration = sessionDuration ?? throw new global::System.ArgumentNullException(nameof(sessionDuration));
            this.SessionCount = sessionCount ?? throw new global::System.ArgumentNullException(nameof(sessionCount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsAverage" /> class.
        /// </summary>
        public SessionMetricsAverage()
        {
        }
    }
}
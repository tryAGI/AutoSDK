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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AverageRow> SessionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AverageRow> SessionDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AverageRow> SessionCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsAverage" /> class.
        /// </summary>
        /// <param name="sessionCost"></param>
        /// <param name="sessionDuration"></param>
        /// <param name="sessionCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
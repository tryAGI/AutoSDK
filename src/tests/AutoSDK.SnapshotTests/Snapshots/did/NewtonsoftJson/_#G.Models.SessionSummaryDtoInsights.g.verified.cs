//HintName: G.Models.SessionSummaryDtoInsights.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionSummaryDtoInsights
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headline")]
        public string? Headline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcome")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionSummaryDtoInsightsOutcomeJsonConverter))]
        public global::G.SessionSummaryDtoInsightsOutcome? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummaryDtoInsights" /> class.
        /// </summary>
        /// <param name="headline"></param>
        /// <param name="outcome"></param>
        public SessionSummaryDtoInsights(
            string? headline,
            global::G.SessionSummaryDtoInsightsOutcome? outcome)
        {
            this.Headline = headline;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummaryDtoInsights" /> class.
        /// </summary>
        public SessionSummaryDtoInsights()
        {
        }
    }
}
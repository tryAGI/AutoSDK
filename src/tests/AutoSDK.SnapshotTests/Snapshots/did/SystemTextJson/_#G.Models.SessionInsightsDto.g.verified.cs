//HintName: G.Models.SessionInsightsDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionInsightsDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headline")]
        public string? Headline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionInsightsDtoOutcomeJsonConverter))]
        public global::G.SessionInsightsDtoOutcome? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInsightsDto" /> class.
        /// </summary>
        /// <param name="headline"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInsightsDto(
            string? headline,
            global::G.SessionInsightsDtoOutcome? outcome)
        {
            this.Headline = headline;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInsightsDto" /> class.
        /// </summary>
        public SessionInsightsDto()
        {
        }
    }
}
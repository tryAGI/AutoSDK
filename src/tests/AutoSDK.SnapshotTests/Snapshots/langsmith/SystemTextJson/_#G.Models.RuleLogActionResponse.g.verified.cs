//HintName: G.Models.RuleLogActionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleLogActionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RuleLogActionOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RuleLogActionOutcome Outcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogActionResponse" /> class.
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleLogActionResponse(
            global::G.RuleLogActionOutcome outcome,
            object? payload)
        {
            this.Outcome = outcome;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogActionResponse" /> class.
        /// </summary>
        public RuleLogActionResponse()
        {
        }
    }
}
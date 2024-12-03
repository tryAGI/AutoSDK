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
        [global::Newtonsoft.Json.JsonProperty("outcome", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RuleLogActionOutcome Outcome { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogActionResponse" /> class.
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="payload"></param>
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
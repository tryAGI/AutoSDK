//HintName: G.Models.ManualEvaluationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManualEvaluationResponse
    {
        /// <summary>
        /// Number of entities queued for evaluation<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("entities_queued")]
        public int? EntitiesQueued { get; set; }

        /// <summary>
        /// Number of rules that will be applied<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("rules_applied")]
        public int? RulesApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEvaluationResponse" /> class.
        /// </summary>
        /// <param name="entitiesQueued">
        /// Number of entities queued for evaluation<br/>
        /// Example: 5
        /// </param>
        /// <param name="rulesApplied">
        /// Number of rules that will be applied<br/>
        /// Example: 2
        /// </param>
        public ManualEvaluationResponse(
            int? entitiesQueued,
            int? rulesApplied)
        {
            this.EntitiesQueued = entitiesQueued;
            this.RulesApplied = rulesApplied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEvaluationResponse" /> class.
        /// </summary>
        public ManualEvaluationResponse()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("entities_queued")]
        public int? EntitiesQueued { get; set; }

        /// <summary>
        /// Number of rules that will be applied<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules_applied")]
        public int? RulesApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
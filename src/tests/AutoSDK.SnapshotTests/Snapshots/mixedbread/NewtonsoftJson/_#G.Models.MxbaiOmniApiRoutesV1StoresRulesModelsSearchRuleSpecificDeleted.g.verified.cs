//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a specific deleted rule from a search rule array.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted
    {
        /// <summary>
        /// The search rule ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type<br/>
        /// Default Value: search_rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The specific rule that was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_rule", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeletedRule2 DeletedRule { get; set; } = default!;

        /// <summary>
        /// Number of rules remaining in the array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining_rules", Required = global::Newtonsoft.Json.Required.Always)]
        public int RemainingRules { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The search rule ID
        /// </param>
        /// <param name="deletedRule">
        /// The specific rule that was deleted
        /// </param>
        /// <param name="remainingRules">
        /// Number of rules remaining in the array
        /// </param>
        /// <param name="object">
        /// The object type<br/>
        /// Default Value: search_rule
        /// </param>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted(
            string id,
            global::G.DeletedRule2 deletedRule,
            int remainingRules,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.DeletedRule = deletedRule;
            this.RemainingRules = remainingRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted()
        {
        }
    }
}
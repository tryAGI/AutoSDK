//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for specific deleted rule.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted
    {
        /// <summary>
        /// The search rule ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type<br/>
        /// Default Value: search_rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The specific rule that was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_rule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeletedRuleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeletedRule DeletedRule { get; set; }

        /// <summary>
        /// Number of rules remaining in the array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemainingRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted(
            string id,
            global::G.DeletedRule deletedRule,
            int remainingRules,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.DeletedRule = deletedRule;
            this.RemainingRules = remainingRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted()
        {
        }
    }
}
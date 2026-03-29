//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for updating an existing search rule for a store.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams
    {
        /// <summary>
        /// The query pattern to match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The rules to apply on query matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::G.RulesVariant1Item2>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams" /> class.
        /// </summary>
        /// <param name="query">
        /// The query pattern to match
        /// </param>
        /// <param name="rules">
        /// The rules to apply on query matches
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams(
            string? query,
            global::System.Collections.Generic.IList<global::G.RulesVariant1Item2>? rules)
        {
            this.Query = query;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParams()
        {
        }
    }
}
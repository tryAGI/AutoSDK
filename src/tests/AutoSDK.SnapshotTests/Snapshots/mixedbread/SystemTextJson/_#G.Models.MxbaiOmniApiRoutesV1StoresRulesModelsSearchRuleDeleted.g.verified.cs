//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for deleted store search rule.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted
    {
        /// <summary>
        /// Whether the search rule was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The object type<br/>
        /// Default Value: search_rule.deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the search rule was deleted
        /// </param>
        /// <param name="object">
        /// The object type<br/>
        /// Default Value: search_rule.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted(
            bool deleted,
            string? @object)
        {
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleDeleted()
        {
        }
    }
}
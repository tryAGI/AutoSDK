//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a store search rule.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse
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
        /// The query pattern
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The store ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The rules to apply
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RulesItem4> Rules { get; set; } = default!;

        /// <summary>
        /// When the rule was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When the rule was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The search rule ID
        /// </param>
        /// <param name="query">
        /// The query pattern
        /// </param>
        /// <param name="storeId">
        /// The store ID
        /// </param>
        /// <param name="rules">
        /// The rules to apply
        /// </param>
        /// <param name="createdAt">
        /// When the rule was created
        /// </param>
        /// <param name="updatedAt">
        /// When the rule was last updated
        /// </param>
        /// <param name="object">
        /// The object type<br/>
        /// Default Value: search_rule
        /// </param>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse(
            string id,
            string query,
            string storeId,
            global::System.Collections.Generic.IList<global::G.RulesItem4> rules,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse()
        {
        }
    }
}
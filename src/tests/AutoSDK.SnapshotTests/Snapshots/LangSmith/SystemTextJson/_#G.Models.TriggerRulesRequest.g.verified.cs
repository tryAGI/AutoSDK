//HintName: G.Models.TriggerRulesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerRulesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RuleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRulesRequest" /> class.
        /// </summary>
        /// <param name="ruleIds"></param>
        /// <param name="datasetId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerRulesRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? ruleIds,
            global::System.Guid? datasetId)
        {
            this.RuleIds = ruleIds;
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRulesRequest" /> class.
        /// </summary>
        public TriggerRulesRequest()
        {
        }
    }
}
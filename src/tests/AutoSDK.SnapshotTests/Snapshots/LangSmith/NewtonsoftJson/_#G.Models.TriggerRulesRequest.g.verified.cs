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
        [global::Newtonsoft.Json.JsonProperty("rule_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RuleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRulesRequest" /> class.
        /// </summary>
        /// <param name="ruleIds"></param>
        /// <param name="datasetId"></param>
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
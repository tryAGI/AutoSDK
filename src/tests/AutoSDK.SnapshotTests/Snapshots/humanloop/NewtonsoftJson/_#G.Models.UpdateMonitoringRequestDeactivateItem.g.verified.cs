//HintName: G.Models.UpdateMonitoringRequestDeactivateItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMonitoringRequestDeactivateItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorId")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorVersionId")]
        public string? EvaluatorVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequestDeactivateItem" /> class.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="evaluatorVersionId"></param>
        public UpdateMonitoringRequestDeactivateItem(
            string? evaluatorId,
            string? evaluatorVersionId)
        {
            this.EvaluatorId = evaluatorId;
            this.EvaluatorVersionId = evaluatorVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequestDeactivateItem" /> class.
        /// </summary>
        public UpdateMonitoringRequestDeactivateItem()
        {
        }
    }
}
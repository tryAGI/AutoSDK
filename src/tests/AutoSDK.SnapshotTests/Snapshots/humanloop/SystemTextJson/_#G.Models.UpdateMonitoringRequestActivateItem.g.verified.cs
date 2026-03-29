//HintName: G.Models.UpdateMonitoringRequestActivateItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMonitoringRequestActivateItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorId")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorVersionId")]
        public string? EvaluatorVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequestActivateItem" /> class.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="evaluatorVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMonitoringRequestActivateItem(
            string? evaluatorId,
            string? evaluatorVersionId)
        {
            this.EvaluatorId = evaluatorId;
            this.EvaluatorVersionId = evaluatorVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequestActivateItem" /> class.
        /// </summary>
        public UpdateMonitoringRequestActivateItem()
        {
        }
    }
}
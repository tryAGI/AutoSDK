//HintName: G.Models.ResearchEventDtoClassVariant3Variant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3Variant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant3Variant2EventTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant3Variant2EventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchOperationDtoClassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResearchOperationDtoClass Data { get; set; }

        /// <summary>
        /// Milliseconds since epoch time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("researchId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResearchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant2" /> class.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="taskId"></param>
        /// <param name="operationId"></param>
        /// <param name="data"></param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="researchId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant3Variant2(
            string planId,
            string taskId,
            string operationId,
            global::G.ResearchOperationDtoClass data,
            double createdAt,
            string researchId,
            global::G.ResearchEventDtoClassVariant3Variant2EventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Data = data;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant2" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3Variant2()
        {
        }
    }
}
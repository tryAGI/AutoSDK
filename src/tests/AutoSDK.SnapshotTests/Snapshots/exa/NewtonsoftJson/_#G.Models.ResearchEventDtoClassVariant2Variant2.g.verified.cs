//HintName: G.Models.ResearchEventDtoClassVariant2Variant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2Variant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eventType")]
        public global::G.ResearchEventDtoClassVariant2Variant2EventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("planId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OperationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchOperationDtoClass Data { get; set; } = default!;

        /// <summary>
        /// Milliseconds since epoch time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("researchId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResearchId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant2" /> class.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="operationId"></param>
        /// <param name="data"></param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="researchId"></param>
        /// <param name="eventType"></param>
        public ResearchEventDtoClassVariant2Variant2(
            string planId,
            string operationId,
            global::G.ResearchOperationDtoClass data,
            double createdAt,
            string researchId,
            global::G.ResearchEventDtoClassVariant2Variant2EventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Data = data;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant2" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2Variant2()
        {
        }
    }
}
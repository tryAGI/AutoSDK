//HintName: G.Models.ResearchEventDtoClassVariant2Variant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2Variant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3EventTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant2Variant3EventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Output2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Output2 Output { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3" /> class.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="output"></param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="researchId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2Variant3(
            string planId,
            global::G.Output2 output,
            double createdAt,
            string researchId,
            global::G.ResearchEventDtoClassVariant2Variant3EventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.Output = output;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2Variant3()
        {
        }
    }
}
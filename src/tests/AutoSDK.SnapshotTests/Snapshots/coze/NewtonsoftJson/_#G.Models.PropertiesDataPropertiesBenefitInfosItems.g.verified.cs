//HintName: G.Models.PropertiesDataPropertiesBenefitInfosItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfosItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_mode")]
        public string? ActiveMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("benefit_type")]
        public string? BenefitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at")]
        public int? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_time")]
        public int? TriggerTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_unit")]
        public string? TriggerUnit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfosItems" /> class.
        /// </summary>
        /// <param name="activeMode"></param>
        /// <param name="benefitType"></param>
        /// <param name="endedAt"></param>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="limit"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="triggerTime"></param>
        /// <param name="triggerUnit"></param>
        public PropertiesDataPropertiesBenefitInfosItems(
            string? activeMode,
            string? benefitType,
            int? endedAt,
            string? entityId,
            string? entityType,
            int? limit,
            int? startedAt,
            string? status,
            int? triggerTime,
            string? triggerUnit)
        {
            this.ActiveMode = activeMode;
            this.BenefitType = benefitType;
            this.EndedAt = endedAt;
            this.EntityId = entityId;
            this.EntityType = entityType;
            this.Limit = limit;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TriggerTime = triggerTime;
            this.TriggerUnit = triggerUnit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfosItems" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfosItems()
        {
        }
    }
}
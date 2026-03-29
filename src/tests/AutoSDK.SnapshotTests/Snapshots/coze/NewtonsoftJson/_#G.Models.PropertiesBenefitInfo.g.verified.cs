//HintName: G.Models.PropertiesBenefitInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesBenefitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public string ActiveMode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("benefit_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string BenefitType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PropertiesBenefitInfo" /> class.
        /// </summary>
        /// <param name="activeMode"></param>
        /// <param name="benefitType"></param>
        /// <param name="endedAt"></param>
        /// <param name="limit"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="triggerTime"></param>
        /// <param name="triggerUnit"></param>
        public PropertiesBenefitInfo(
            string activeMode,
            string benefitType,
            int endedAt,
            int limit,
            int startedAt,
            string? status,
            int? triggerTime,
            string? triggerUnit)
        {
            this.ActiveMode = activeMode ?? throw new global::System.ArgumentNullException(nameof(activeMode));
            this.BenefitType = benefitType ?? throw new global::System.ArgumentNullException(nameof(benefitType));
            this.EndedAt = endedAt;
            this.Limit = limit;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TriggerTime = triggerTime;
            this.TriggerUnit = triggerUnit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesBenefitInfo" /> class.
        /// </summary>
        public PropertiesBenefitInfo()
        {
        }
    }
}
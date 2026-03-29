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
        [global::System.Text.Json.Serialization.JsonPropertyName("active_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActiveMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BenefitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_time")]
        public int? TriggerTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_unit")]
        public string? TriggerUnit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
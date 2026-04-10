//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo
    {
        /// <summary>
        /// 结束时间，单位秒
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_at")]
        public int? EndAt { get; set; }

        /// <summary>
        /// 开始时间，单位秒
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_at")]
        public int? StartAt { get; set; }

        /// <summary>
        /// 资源使用策略
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyJsonConverter))]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy? Strategy { get; set; }

        /// <summary>
        /// 当 Strategy == ByQuota 时, 表示用量上限
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public double? Total { get; set; }

        /// <summary>
        /// 当 Strategy == ByQuota 时, 表示已使用量, 若权益无相关用量数据则返回 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used")]
        public double? Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo" /> class.
        /// </summary>
        /// <param name="endAt">
        /// 结束时间，单位秒
        /// </param>
        /// <param name="startAt">
        /// 开始时间，单位秒
        /// </param>
        /// <param name="strategy">
        /// 资源使用策略
        /// </param>
        /// <param name="total">
        /// 当 Strategy == ByQuota 时, 表示用量上限
        /// </param>
        /// <param name="used">
        /// 当 Strategy == ByQuota 时, 表示已使用量, 若权益无相关用量数据则返回 0
        /// </param>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo(
            int? endAt,
            int? startAt,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy? strategy,
            double? total,
            double? used)
        {
            this.EndAt = endAt;
            this.StartAt = startAt;
            this.Strategy = strategy;
            this.Total = total;
            this.Used = used;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo()
        {
        }
    }
}
//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo
    {
        /// <summary>
        /// 结束时间，单位秒
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public int? EndAt { get; set; }

        /// <summary>
        /// 开始时间，单位秒
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        public int? StartAt { get; set; }

        /// <summary>
        /// 资源使用策略
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyJsonConverter))]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy? Strategy { get; set; }

        /// <summary>
        /// 当 Strategy == ByQuota 时, 表示用量上限
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// 当 Strategy == ByQuota 时, 表示已使用量, 若权益无相关用量数据则返回 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public double? Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo(
            int? endAt,
            int? startAt,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy? strategy,
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
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo()
        {
        }
    }
}
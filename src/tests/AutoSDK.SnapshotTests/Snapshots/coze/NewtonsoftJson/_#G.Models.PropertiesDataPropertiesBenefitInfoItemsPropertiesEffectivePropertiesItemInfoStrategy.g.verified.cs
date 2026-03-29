//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 资源使用策略
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="by_quota")]
        ByQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forbidden")]
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unlimit")]
        Unlimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.ByQuota => "by_quota",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.Forbidden => "forbidden",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.Unlimit => "unlimit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy? ToEnum(string value)
        {
            return value switch
            {
                "by_quota" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.ByQuota,
                "forbidden" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.Forbidden,
                "unlimit" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.Unlimit,
                _ => null,
            };
        }
    }
}
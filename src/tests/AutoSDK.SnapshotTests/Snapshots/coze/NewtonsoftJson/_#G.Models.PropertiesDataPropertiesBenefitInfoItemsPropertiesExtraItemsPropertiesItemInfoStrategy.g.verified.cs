//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 资源使用策略
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy
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
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.ByQuota => "by_quota",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.Forbidden => "forbidden",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.Unlimit => "unlimit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy? ToEnum(string value)
        {
            return value switch
            {
                "by_quota" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.ByQuota,
                "forbidden" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.Forbidden,
                "unlimit" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.Unlimit,
                _ => null,
            };
        }
    }
}
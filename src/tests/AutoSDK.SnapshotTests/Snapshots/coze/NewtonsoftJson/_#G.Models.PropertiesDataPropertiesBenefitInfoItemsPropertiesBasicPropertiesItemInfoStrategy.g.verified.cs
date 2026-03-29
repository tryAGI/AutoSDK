//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 资源使用策略
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy
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
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.ByQuota => "by_quota",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.Forbidden => "forbidden",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.Unlimit => "unlimit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy? ToEnum(string value)
        {
            return value switch
            {
                "by_quota" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.ByQuota,
                "forbidden" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.Forbidden,
                "unlimit" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy.Unlimit,
                _ => null,
            };
        }
    }
}
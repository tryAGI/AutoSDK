//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Auditing,
        /// <summary>
        /// 
        /// </summary>
        Cancel,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Frozen,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Auditing => "auditing",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Cancel => "cancel",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Expired => "expired",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Frozen => "frozen",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Invalid => "invalid",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Pending => "pending",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus? ToEnum(string value)
        {
            return value switch
            {
                "auditing" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Auditing,
                "cancel" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Cancel,
                "expired" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Expired,
                "frozen" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Frozen,
                "invalid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Invalid,
                "pending" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Pending,
                "valid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.Valid,
                _ => null,
            };
        }
    }
}
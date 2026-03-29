//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus
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
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Auditing => "auditing",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Cancel => "cancel",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Expired => "expired",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Frozen => "frozen",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Invalid => "invalid",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Pending => "pending",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "auditing" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Auditing,
                "cancel" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Cancel,
                "expired" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Expired,
                "frozen" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Frozen,
                "invalid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Invalid,
                "pending" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Pending,
                "valid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus.Valid,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus
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
    public static class PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Auditing => "auditing",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Cancel => "cancel",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Expired => "expired",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Frozen => "frozen",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Invalid => "invalid",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Pending => "pending",
                PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus? ToEnum(string value)
        {
            return value switch
            {
                "auditing" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Auditing,
                "cancel" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Cancel,
                "expired" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Expired,
                "frozen" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Frozen,
                "invalid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Invalid,
                "pending" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Pending,
                "valid" => PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.Valid,
                _ => null,
            };
        }
    }
}
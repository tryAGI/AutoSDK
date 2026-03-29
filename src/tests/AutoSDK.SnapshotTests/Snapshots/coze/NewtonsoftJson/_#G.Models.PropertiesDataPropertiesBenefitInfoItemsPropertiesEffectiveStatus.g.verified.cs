//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auditing")]
        Auditing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancel")]
        Cancel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frozen")]
        Frozen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid")]
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valid")]
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
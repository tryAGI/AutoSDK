//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus
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
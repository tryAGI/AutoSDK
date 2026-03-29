//HintName: G.Models.V2CallBaseDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data storage setting for this call's agent. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata.<br/>
    /// Example: everything
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V2CallBaseDataStorageSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic_attributes_only")]
        BasicAttributesOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everything")]
        Everything,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everything_except_pii")]
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2CallBaseDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2CallBaseDataStorageSetting value)
        {
            return value switch
            {
                V2CallBaseDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                V2CallBaseDataStorageSetting.Everything => "everything",
                V2CallBaseDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2CallBaseDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => V2CallBaseDataStorageSetting.BasicAttributesOnly,
                "everything" => V2CallBaseDataStorageSetting.Everything,
                "everything_except_pii" => V2CallBaseDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}
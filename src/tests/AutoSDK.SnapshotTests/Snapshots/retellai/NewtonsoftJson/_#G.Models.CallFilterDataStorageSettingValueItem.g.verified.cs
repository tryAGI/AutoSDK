//HintName: G.Models.CallFilterDataStorageSettingValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallFilterDataStorageSettingValueItem
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
    public static class CallFilterDataStorageSettingValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallFilterDataStorageSettingValueItem value)
        {
            return value switch
            {
                CallFilterDataStorageSettingValueItem.BasicAttributesOnly => "basic_attributes_only",
                CallFilterDataStorageSettingValueItem.Everything => "everything",
                CallFilterDataStorageSettingValueItem.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallFilterDataStorageSettingValueItem? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => CallFilterDataStorageSettingValueItem.BasicAttributesOnly,
                "everything" => CallFilterDataStorageSettingValueItem.Everything,
                "everything_except_pii" => CallFilterDataStorageSettingValueItem.EverythingExceptPii,
                _ => null,
            };
        }
    }
}
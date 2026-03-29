//HintName: G.Models.UpdateChatMetadataRequestDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data storage setting for this chat. Overrides the agent's default setting. "everything" stores all data, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
    /// Example: everything
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateChatMetadataRequestDataStorageSetting
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatMetadataRequestDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatMetadataRequestDataStorageSetting value)
        {
            return value switch
            {
                UpdateChatMetadataRequestDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                UpdateChatMetadataRequestDataStorageSetting.Everything => "everything",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatMetadataRequestDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => UpdateChatMetadataRequestDataStorageSetting.BasicAttributesOnly,
                "everything" => UpdateChatMetadataRequestDataStorageSetting.Everything,
                _ => null,
            };
        }
    }
}
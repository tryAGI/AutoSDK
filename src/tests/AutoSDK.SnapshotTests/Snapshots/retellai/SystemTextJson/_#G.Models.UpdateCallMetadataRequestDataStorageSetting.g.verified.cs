//HintName: G.Models.UpdateCallMetadataRequestDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
    /// Example: everything_except_pii
    /// </summary>
    public enum UpdateCallMetadataRequestDataStorageSetting
    {
        /// <summary>
        /// 
        /// </summary>
        BasicAttributesOnly,
        /// <summary>
        /// 
        /// </summary>
        Everything,
        /// <summary>
        /// 
        /// </summary>
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCallMetadataRequestDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCallMetadataRequestDataStorageSetting value)
        {
            return value switch
            {
                UpdateCallMetadataRequestDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                UpdateCallMetadataRequestDataStorageSetting.Everything => "everything",
                UpdateCallMetadataRequestDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCallMetadataRequestDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => UpdateCallMetadataRequestDataStorageSetting.BasicAttributesOnly,
                "everything" => UpdateCallMetadataRequestDataStorageSetting.Everything,
                "everything_except_pii" => UpdateCallMetadataRequestDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}
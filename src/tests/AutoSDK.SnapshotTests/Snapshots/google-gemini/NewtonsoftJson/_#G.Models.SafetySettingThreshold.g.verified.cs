//HintName: G.Models.SafetySettingThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. Controls the probability threshold at which harm is blocked.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SafetySettingThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_BLOCK_THRESHOLD_UNSPECIFIED")]
        HARMBLOCKTHRESHOLDUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_LOW_AND_ABOVE")]
        BLOCKLOWANDABOVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_MEDIUM_AND_ABOVE")]
        BLOCKMEDIUMANDABOVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_ONLY_HIGH")]
        BLOCKONLYHIGH,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_NONE")]
        BLOCKNONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetySettingThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingThreshold value)
        {
            return value switch
            {
                SafetySettingThreshold.HARMBLOCKTHRESHOLDUNSPECIFIED => "HARM_BLOCK_THRESHOLD_UNSPECIFIED",
                SafetySettingThreshold.BLOCKLOWANDABOVE => "BLOCK_LOW_AND_ABOVE",
                SafetySettingThreshold.BLOCKMEDIUMANDABOVE => "BLOCK_MEDIUM_AND_ABOVE",
                SafetySettingThreshold.BLOCKONLYHIGH => "BLOCK_ONLY_HIGH",
                SafetySettingThreshold.BLOCKNONE => "BLOCK_NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetySettingThreshold? ToEnum(string value)
        {
            return value switch
            {
                "HARM_BLOCK_THRESHOLD_UNSPECIFIED" => SafetySettingThreshold.HARMBLOCKTHRESHOLDUNSPECIFIED,
                "BLOCK_LOW_AND_ABOVE" => SafetySettingThreshold.BLOCKLOWANDABOVE,
                "BLOCK_MEDIUM_AND_ABOVE" => SafetySettingThreshold.BLOCKMEDIUMANDABOVE,
                "BLOCK_ONLY_HIGH" => SafetySettingThreshold.BLOCKONLYHIGH,
                "BLOCK_NONE" => SafetySettingThreshold.BLOCKNONE,
                _ => null,
            };
        }
    }
}
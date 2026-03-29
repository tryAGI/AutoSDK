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
        /// Content with NEGLIGIBLE will be allowed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_LOW_AND_ABOVE")]
        BlockLowAndAbove,
        /// <summary>
        /// Content with NEGLIGIBLE and LOW will be allowed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_MEDIUM_AND_ABOVE")]
        BlockMediumAndAbove,
        /// <summary>
        /// All content will be allowed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_NONE")]
        BlockNone,
        /// <summary>
        /// Content with NEGLIGIBLE, LOW, and MEDIUM will be allowed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_ONLY_HIGH")]
        BlockOnlyHigh,
        /// <summary>
        /// Threshold is unspecified.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_BLOCK_THRESHOLD_UNSPECIFIED")]
        HarmBlockThresholdUnspecified,
        /// <summary>
        /// Turn off the safety filter.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFF")]
        Off,
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
                SafetySettingThreshold.BlockLowAndAbove => "BLOCK_LOW_AND_ABOVE",
                SafetySettingThreshold.BlockMediumAndAbove => "BLOCK_MEDIUM_AND_ABOVE",
                SafetySettingThreshold.BlockNone => "BLOCK_NONE",
                SafetySettingThreshold.BlockOnlyHigh => "BLOCK_ONLY_HIGH",
                SafetySettingThreshold.HarmBlockThresholdUnspecified => "HARM_BLOCK_THRESHOLD_UNSPECIFIED",
                SafetySettingThreshold.Off => "OFF",
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
                "BLOCK_LOW_AND_ABOVE" => SafetySettingThreshold.BlockLowAndAbove,
                "BLOCK_MEDIUM_AND_ABOVE" => SafetySettingThreshold.BlockMediumAndAbove,
                "BLOCK_NONE" => SafetySettingThreshold.BlockNone,
                "BLOCK_ONLY_HIGH" => SafetySettingThreshold.BlockOnlyHigh,
                "HARM_BLOCK_THRESHOLD_UNSPECIFIED" => SafetySettingThreshold.HarmBlockThresholdUnspecified,
                "OFF" => SafetySettingThreshold.Off,
                _ => null,
            };
        }
    }
}
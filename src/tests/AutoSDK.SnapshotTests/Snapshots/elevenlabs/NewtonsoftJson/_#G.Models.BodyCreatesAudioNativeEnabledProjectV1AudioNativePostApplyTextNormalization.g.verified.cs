//HintName: G.Models.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_english")]
        ApplyEnglish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization value)
        {
            return value switch
            {
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.ApplyEnglish => "apply_english",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.Auto => "auto",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.Off => "off",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "apply_english" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.ApplyEnglish,
                "auto" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.Auto,
                "off" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.Off,
                "on" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}
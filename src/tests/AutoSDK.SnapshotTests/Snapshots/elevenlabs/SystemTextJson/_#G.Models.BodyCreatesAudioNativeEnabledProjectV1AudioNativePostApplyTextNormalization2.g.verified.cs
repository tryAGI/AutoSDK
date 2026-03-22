//HintName: G.Models.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyEnglish,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2 value)
        {
            return value switch
            {
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.ApplyEnglish => "apply_english",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.Auto => "auto",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.Off => "off",
                BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2? ToEnum(string value)
        {
            return value switch
            {
                "apply_english" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.ApplyEnglish,
                "auto" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.Auto,
                "off" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.Off,
                "on" => BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2.On,
                _ => null,
            };
        }
    }
}
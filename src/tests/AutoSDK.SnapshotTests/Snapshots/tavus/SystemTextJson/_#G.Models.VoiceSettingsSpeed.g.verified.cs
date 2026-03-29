//HintName: G.Models.VoiceSettingsSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceSettingsSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Fastest,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Slow,
        /// <summary>
        /// 
        /// </summary>
        Slowest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSettingsSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSettingsSpeed value)
        {
            return value switch
            {
                VoiceSettingsSpeed.Fast => "fast",
                VoiceSettingsSpeed.Fastest => "fastest",
                VoiceSettingsSpeed.Normal => "normal",
                VoiceSettingsSpeed.Slow => "slow",
                VoiceSettingsSpeed.Slowest => "slowest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSettingsSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => VoiceSettingsSpeed.Fast,
                "fastest" => VoiceSettingsSpeed.Fastest,
                "normal" => VoiceSettingsSpeed.Normal,
                "slow" => VoiceSettingsSpeed.Slow,
                "slowest" => VoiceSettingsSpeed.Slowest,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.VoiceSettingsSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceSettingsSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fastest")]
        Fastest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slow")]
        Slow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slowest")]
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
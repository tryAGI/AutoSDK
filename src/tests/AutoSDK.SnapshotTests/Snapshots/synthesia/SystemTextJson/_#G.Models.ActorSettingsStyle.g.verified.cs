//HintName: G.Models.ActorSettingsStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `rectangular` style corresponds to the "Full body" avatar style in STUDIO. `circular style corresponds to the "Circle" avatar style in STUDIO. The position of circular avatar is fixed to the center of the video both vertically and horizontally, and can't be changed. With scale 1.0, circular avatar will cover total height of the video. Use circular style, if you need to make a round cutout of the avatar to integrate into e.g. screen recording app
    /// </summary>
    public enum ActorSettingsStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Circular,
        /// <summary>
        /// 
        /// </summary>
        Rectangular,
        /// <summary>
        /// 
        /// </summary>
        VoiceOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorSettingsStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorSettingsStyle value)
        {
            return value switch
            {
                ActorSettingsStyle.Circular => "circular",
                ActorSettingsStyle.Rectangular => "rectangular",
                ActorSettingsStyle.VoiceOnly => "voiceOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorSettingsStyle? ToEnum(string value)
        {
            return value switch
            {
                "circular" => ActorSettingsStyle.Circular,
                "rectangular" => ActorSettingsStyle.Rectangular,
                "voiceOnly" => ActorSettingsStyle.VoiceOnly,
                _ => null,
            };
        }
    }
}
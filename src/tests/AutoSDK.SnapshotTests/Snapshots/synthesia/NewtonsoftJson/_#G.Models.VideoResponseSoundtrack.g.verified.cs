//HintName: G.Models.VideoResponseSoundtrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoResponseSoundtrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="corporate")]
        Corporate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inspirational")]
        Inspirational,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modern")]
        Modern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="urban")]
        Urban,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseSoundtrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseSoundtrack value)
        {
            return value switch
            {
                VideoResponseSoundtrack.Corporate => "corporate",
                VideoResponseSoundtrack.Inspirational => "inspirational",
                VideoResponseSoundtrack.Modern => "modern",
                VideoResponseSoundtrack.Urban => "urban",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseSoundtrack? ToEnum(string value)
        {
            return value switch
            {
                "corporate" => VideoResponseSoundtrack.Corporate,
                "inspirational" => VideoResponseSoundtrack.Inspirational,
                "modern" => VideoResponseSoundtrack.Modern,
                "urban" => VideoResponseSoundtrack.Urban,
                _ => null,
            };
        }
    }
}
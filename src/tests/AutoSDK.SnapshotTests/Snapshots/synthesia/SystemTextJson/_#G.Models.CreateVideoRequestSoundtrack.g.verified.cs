//HintName: G.Models.CreateVideoRequestSoundtrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
    /// </summary>
    public enum CreateVideoRequestSoundtrack
    {
        /// <summary>
        /// 
        /// </summary>
        Corporate,
        /// <summary>
        /// 
        /// </summary>
        Inspirational,
        /// <summary>
        /// 
        /// </summary>
        Modern,
        /// <summary>
        /// 
        /// </summary>
        Urban,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoRequestSoundtrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestSoundtrack value)
        {
            return value switch
            {
                CreateVideoRequestSoundtrack.Corporate => "corporate",
                CreateVideoRequestSoundtrack.Inspirational => "inspirational",
                CreateVideoRequestSoundtrack.Modern => "modern",
                CreateVideoRequestSoundtrack.Urban => "urban",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestSoundtrack? ToEnum(string value)
        {
            return value switch
            {
                "corporate" => CreateVideoRequestSoundtrack.Corporate,
                "inspirational" => CreateVideoRequestSoundtrack.Inspirational,
                "modern" => CreateVideoRequestSoundtrack.Modern,
                "urban" => CreateVideoRequestSoundtrack.Urban,
                _ => null,
            };
        }
    }
}
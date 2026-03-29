//HintName: G.Models.HeyGenTextToAvatarOptionsRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aspect ratio of the video, `16:9` horizontal or `9:16` vertical. Defaults to `16:9`.
    /// </summary>
    public enum HeyGenTextToAvatarOptionsRatio
    {
        /// <summary>
        /// 9` horizontal or `9:16` vertical. Defaults to `16:9`.
        /// </summary>
        x16_9,
        /// <summary>
        /// 9` horizontal or `9:16` vertical. Defaults to `16:9`.
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeyGenTextToAvatarOptionsRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeyGenTextToAvatarOptionsRatio value)
        {
            return value switch
            {
                HeyGenTextToAvatarOptionsRatio.x16_9 => "16:9",
                HeyGenTextToAvatarOptionsRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeyGenTextToAvatarOptionsRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => HeyGenTextToAvatarOptionsRatio.x16_9,
                "9:16" => HeyGenTextToAvatarOptionsRatio.x9_16,
                _ => null,
            };
        }
    }
}
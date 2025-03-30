//HintName: G.Models.PodcastBulletinModeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of podcast to create.
    /// </summary>
    public enum PodcastBulletinModeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bulletin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PodcastBulletinModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PodcastBulletinModeType value)
        {
            return value switch
            {
                PodcastBulletinModeType.Bulletin => "bulletin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PodcastBulletinModeType? ToEnum(string value)
        {
            return value switch
            {
                "bulletin" => PodcastBulletinModeType.Bulletin,
                _ => null,
            };
        }
    }
}
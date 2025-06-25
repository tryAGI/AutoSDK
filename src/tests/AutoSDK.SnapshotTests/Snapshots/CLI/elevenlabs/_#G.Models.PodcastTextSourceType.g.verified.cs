//HintName: G.Models.PodcastTextSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of source to create.
    /// </summary>
    public enum PodcastTextSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PodcastTextSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PodcastTextSourceType value)
        {
            return value switch
            {
                PodcastTextSourceType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PodcastTextSourceType? ToEnum(string value)
        {
            return value switch
            {
                "text" => PodcastTextSourceType.Text,
                _ => null,
            };
        }
    }
}
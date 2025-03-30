//HintName: G.Models.PodcastURLSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of source to create.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PodcastURLSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PodcastURLSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PodcastURLSourceType value)
        {
            return value switch
            {
                PodcastURLSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PodcastURLSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => PodcastURLSourceType.Url,
                _ => null,
            };
        }
    }
}
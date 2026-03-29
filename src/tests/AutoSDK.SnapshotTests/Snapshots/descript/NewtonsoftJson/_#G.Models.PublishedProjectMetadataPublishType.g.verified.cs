//HintName: G.Models.PublishedProjectMetadataPublishType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of published project<br/>
    /// Example: video
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublishedProjectMetadataPublishType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audiogram")]
        Audiogram,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectMetadataPublishTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectMetadataPublishType value)
        {
            return value switch
            {
                PublishedProjectMetadataPublishType.Audio => "audio",
                PublishedProjectMetadataPublishType.Audiogram => "audiogram",
                PublishedProjectMetadataPublishType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectMetadataPublishType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => PublishedProjectMetadataPublishType.Audio,
                "audiogram" => PublishedProjectMetadataPublishType.Audiogram,
                "video" => PublishedProjectMetadataPublishType.Video,
                _ => null,
            };
        }
    }
}
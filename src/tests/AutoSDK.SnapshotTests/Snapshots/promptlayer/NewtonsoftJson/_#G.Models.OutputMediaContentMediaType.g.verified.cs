//HintName: G.Models.OutputMediaContentMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputMediaContentMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMediaContentMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMediaContentMediaType value)
        {
            return value switch
            {
                OutputMediaContentMediaType.Audio => "audio",
                OutputMediaContentMediaType.Image => "image",
                OutputMediaContentMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMediaContentMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => OutputMediaContentMediaType.Audio,
                "image" => OutputMediaContentMediaType.Image,
                "video" => OutputMediaContentMediaType.Video,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageGif => "image/gif",
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageJpeg => "image/jpeg",
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImagePng => "image/png",
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageGif,
                "image/jpeg" => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageJpeg,
                "image/png" => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImagePng,
                "image/webp" => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaType.ImageWebp,
                _ => null,
            };
        }
    }
}
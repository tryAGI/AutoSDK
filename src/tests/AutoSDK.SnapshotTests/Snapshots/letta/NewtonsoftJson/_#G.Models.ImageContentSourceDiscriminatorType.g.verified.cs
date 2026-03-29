//HintName: G.Models.ImageContentSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageContentSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta")]
        Letta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageContentSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageContentSourceDiscriminatorType value)
        {
            return value switch
            {
                ImageContentSourceDiscriminatorType.Base64 => "base64",
                ImageContentSourceDiscriminatorType.Letta => "letta",
                ImageContentSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageContentSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ImageContentSourceDiscriminatorType.Base64,
                "letta" => ImageContentSourceDiscriminatorType.Letta,
                "url" => ImageContentSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}
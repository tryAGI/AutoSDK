//HintName: G.Models.AssetDtoVariant1MimeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetDtoVariant1MimeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/gif")]
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/jpeg")]
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/jpg")]
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/png")]
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/webp")]
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/matroska")]
        VideoMatroska,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/mp4")]
        VideoMp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/quicktime")]
        VideoQuicktime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/webm")]
        VideoWebm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/x-matroska")]
        VideoXMatroska,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetDtoVariant1MimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDtoVariant1MimeType value)
        {
            return value switch
            {
                AssetDtoVariant1MimeType.ImageGif => "image/gif",
                AssetDtoVariant1MimeType.ImageJpeg => "image/jpeg",
                AssetDtoVariant1MimeType.ImageJpg => "image/jpg",
                AssetDtoVariant1MimeType.ImagePng => "image/png",
                AssetDtoVariant1MimeType.ImageWebp => "image/webp",
                AssetDtoVariant1MimeType.VideoMatroska => "video/matroska",
                AssetDtoVariant1MimeType.VideoMp4 => "video/mp4",
                AssetDtoVariant1MimeType.VideoQuicktime => "video/quicktime",
                AssetDtoVariant1MimeType.VideoWebm => "video/webm",
                AssetDtoVariant1MimeType.VideoXMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDtoVariant1MimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetDtoVariant1MimeType.ImageGif,
                "image/jpeg" => AssetDtoVariant1MimeType.ImageJpeg,
                "image/jpg" => AssetDtoVariant1MimeType.ImageJpg,
                "image/png" => AssetDtoVariant1MimeType.ImagePng,
                "image/webp" => AssetDtoVariant1MimeType.ImageWebp,
                "video/matroska" => AssetDtoVariant1MimeType.VideoMatroska,
                "video/mp4" => AssetDtoVariant1MimeType.VideoMp4,
                "video/quicktime" => AssetDtoVariant1MimeType.VideoQuicktime,
                "video/webm" => AssetDtoVariant1MimeType.VideoWebm,
                "video/x-matroska" => AssetDtoVariant1MimeType.VideoXMatroska,
                _ => null,
            };
        }
    }
}
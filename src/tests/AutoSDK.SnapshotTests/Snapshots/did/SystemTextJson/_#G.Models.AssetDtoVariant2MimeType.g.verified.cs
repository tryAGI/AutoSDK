//HintName: G.Models.AssetDtoVariant2MimeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetDtoVariant2MimeType
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
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        VideoMatroska,
        /// <summary>
        /// 
        /// </summary>
        VideoMp4,
        /// <summary>
        /// 
        /// </summary>
        VideoQuicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoWebm,
        /// <summary>
        /// 
        /// </summary>
        VideoXMatroska,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetDtoVariant2MimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDtoVariant2MimeType value)
        {
            return value switch
            {
                AssetDtoVariant2MimeType.ImageGif => "image/gif",
                AssetDtoVariant2MimeType.ImageJpeg => "image/jpeg",
                AssetDtoVariant2MimeType.ImageJpg => "image/jpg",
                AssetDtoVariant2MimeType.ImagePng => "image/png",
                AssetDtoVariant2MimeType.ImageWebp => "image/webp",
                AssetDtoVariant2MimeType.VideoMatroska => "video/matroska",
                AssetDtoVariant2MimeType.VideoMp4 => "video/mp4",
                AssetDtoVariant2MimeType.VideoQuicktime => "video/quicktime",
                AssetDtoVariant2MimeType.VideoWebm => "video/webm",
                AssetDtoVariant2MimeType.VideoXMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDtoVariant2MimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetDtoVariant2MimeType.ImageGif,
                "image/jpeg" => AssetDtoVariant2MimeType.ImageJpeg,
                "image/jpg" => AssetDtoVariant2MimeType.ImageJpg,
                "image/png" => AssetDtoVariant2MimeType.ImagePng,
                "image/webp" => AssetDtoVariant2MimeType.ImageWebp,
                "video/matroska" => AssetDtoVariant2MimeType.VideoMatroska,
                "video/mp4" => AssetDtoVariant2MimeType.VideoMp4,
                "video/quicktime" => AssetDtoVariant2MimeType.VideoQuicktime,
                "video/webm" => AssetDtoVariant2MimeType.VideoWebm,
                "video/x-matroska" => AssetDtoVariant2MimeType.VideoXMatroska,
                _ => null,
            };
        }
    }
}
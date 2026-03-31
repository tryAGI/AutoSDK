//HintName: G.Models.AssetMimeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported MIME types for agent assets
    /// </summary>
    public enum AssetMimeType
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
    public static class AssetMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetMimeType value)
        {
            return value switch
            {
                AssetMimeType.ImageGif => "image/gif",
                AssetMimeType.ImageJpeg => "image/jpeg",
                AssetMimeType.ImageJpg => "image/jpg",
                AssetMimeType.ImagePng => "image/png",
                AssetMimeType.ImageWebp => "image/webp",
                AssetMimeType.VideoMatroska => "video/matroska",
                AssetMimeType.VideoMp4 => "video/mp4",
                AssetMimeType.VideoQuicktime => "video/quicktime",
                AssetMimeType.VideoWebm => "video/webm",
                AssetMimeType.VideoXMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetMimeType.ImageGif,
                "image/jpeg" => AssetMimeType.ImageJpeg,
                "image/jpg" => AssetMimeType.ImageJpg,
                "image/png" => AssetMimeType.ImagePng,
                "image/webp" => AssetMimeType.ImageWebp,
                "video/matroska" => AssetMimeType.VideoMatroska,
                "video/mp4" => AssetMimeType.VideoMp4,
                "video/quicktime" => AssetMimeType.VideoQuicktime,
                "video/webm" => AssetMimeType.VideoWebm,
                "video/x-matroska" => AssetMimeType.VideoXMatroska,
                _ => null,
            };
        }
    }
}
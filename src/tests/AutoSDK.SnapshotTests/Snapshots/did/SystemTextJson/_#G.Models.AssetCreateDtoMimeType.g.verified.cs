//HintName: G.Models.AssetCreateDtoMimeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    public enum AssetCreateDtoMimeType
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
    public static class AssetCreateDtoMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetCreateDtoMimeType value)
        {
            return value switch
            {
                AssetCreateDtoMimeType.ImageGif => "image/gif",
                AssetCreateDtoMimeType.ImageJpeg => "image/jpeg",
                AssetCreateDtoMimeType.ImageJpg => "image/jpg",
                AssetCreateDtoMimeType.ImagePng => "image/png",
                AssetCreateDtoMimeType.ImageWebp => "image/webp",
                AssetCreateDtoMimeType.VideoMatroska => "video/matroska",
                AssetCreateDtoMimeType.VideoMp4 => "video/mp4",
                AssetCreateDtoMimeType.VideoQuicktime => "video/quicktime",
                AssetCreateDtoMimeType.VideoWebm => "video/webm",
                AssetCreateDtoMimeType.VideoXMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetCreateDtoMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetCreateDtoMimeType.ImageGif,
                "image/jpeg" => AssetCreateDtoMimeType.ImageJpeg,
                "image/jpg" => AssetCreateDtoMimeType.ImageJpg,
                "image/png" => AssetCreateDtoMimeType.ImagePng,
                "image/webp" => AssetCreateDtoMimeType.ImageWebp,
                "video/matroska" => AssetCreateDtoMimeType.VideoMatroska,
                "video/mp4" => AssetCreateDtoMimeType.VideoMp4,
                "video/quicktime" => AssetCreateDtoMimeType.VideoQuicktime,
                "video/webm" => AssetCreateDtoMimeType.VideoWebm,
                "video/x-matroska" => AssetCreateDtoMimeType.VideoXMatroska,
                _ => null,
            };
        }
    }
}
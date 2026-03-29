//HintName: G.Models.AssetUpdateDtoMimeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MIME type of the asset
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetUpdateDtoMimeType
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
    public static class AssetUpdateDtoMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetUpdateDtoMimeType value)
        {
            return value switch
            {
                AssetUpdateDtoMimeType.ImageGif => "image/gif",
                AssetUpdateDtoMimeType.ImageJpeg => "image/jpeg",
                AssetUpdateDtoMimeType.ImageJpg => "image/jpg",
                AssetUpdateDtoMimeType.ImagePng => "image/png",
                AssetUpdateDtoMimeType.ImageWebp => "image/webp",
                AssetUpdateDtoMimeType.VideoMatroska => "video/matroska",
                AssetUpdateDtoMimeType.VideoMp4 => "video/mp4",
                AssetUpdateDtoMimeType.VideoQuicktime => "video/quicktime",
                AssetUpdateDtoMimeType.VideoWebm => "video/webm",
                AssetUpdateDtoMimeType.VideoXMatroska => "video/x-matroska",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetUpdateDtoMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AssetUpdateDtoMimeType.ImageGif,
                "image/jpeg" => AssetUpdateDtoMimeType.ImageJpeg,
                "image/jpg" => AssetUpdateDtoMimeType.ImageJpg,
                "image/png" => AssetUpdateDtoMimeType.ImagePng,
                "image/webp" => AssetUpdateDtoMimeType.ImageWebp,
                "video/matroska" => AssetUpdateDtoMimeType.VideoMatroska,
                "video/mp4" => AssetUpdateDtoMimeType.VideoMp4,
                "video/quicktime" => AssetUpdateDtoMimeType.VideoQuicktime,
                "video/webm" => AssetUpdateDtoMimeType.VideoWebm,
                "video/x-matroska" => AssetUpdateDtoMimeType.VideoXMatroska,
                _ => null,
            };
        }
    }
}
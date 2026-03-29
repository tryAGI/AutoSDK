//HintName: G.Models.CreateAssetUploadRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset you want to upload.
    /// </summary>
    public enum CreateAssetUploadRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetUploadRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetUploadRequestType value)
        {
            return value switch
            {
                CreateAssetUploadRequestType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetUploadRequestType? ToEnum(string value)
        {
            return value switch
            {
                "video" => CreateAssetUploadRequestType.Video,
                _ => null,
            };
        }
    }
}
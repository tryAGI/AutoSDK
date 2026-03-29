//HintName: G.Models.PublicApiUserUploadedAssetErrorCodes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicApiUserUploadedAssetErrorCodes
    {
        /// <summary>
        /// 
        /// </summary>
        AssetUpload,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetect,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicApiUserUploadedAssetErrorCodesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicApiUserUploadedAssetErrorCodes value)
        {
            return value switch
            {
                PublicApiUserUploadedAssetErrorCodes.AssetUpload => "asset_upload",
                PublicApiUserUploadedAssetErrorCodes.LanguageDetect => "language_detect",
                PublicApiUserUploadedAssetErrorCodes.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicApiUserUploadedAssetErrorCodes? ToEnum(string value)
        {
            return value switch
            {
                "asset_upload" => PublicApiUserUploadedAssetErrorCodes.AssetUpload,
                "language_detect" => PublicApiUserUploadedAssetErrorCodes.LanguageDetect,
                "unknown" => PublicApiUserUploadedAssetErrorCodes.Unknown,
                _ => null,
            };
        }
    }
}
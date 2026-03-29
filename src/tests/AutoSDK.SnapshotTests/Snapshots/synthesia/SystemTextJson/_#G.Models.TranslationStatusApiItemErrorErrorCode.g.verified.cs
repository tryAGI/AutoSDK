//HintName: G.Models.TranslationStatusApiItemErrorErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationStatusApiItemErrorErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AssetNotFound,
        /// <summary>
        /// 
        /// </summary>
        GenerationFailed,
        /// <summary>
        /// 
        /// </summary>
        TranslationFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationStatusApiItemErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationStatusApiItemErrorErrorCode value)
        {
            return value switch
            {
                TranslationStatusApiItemErrorErrorCode.AssetNotFound => "asset_not_found",
                TranslationStatusApiItemErrorErrorCode.GenerationFailed => "generation_failed",
                TranslationStatusApiItemErrorErrorCode.TranslationFailed => "translation_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationStatusApiItemErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "asset_not_found" => TranslationStatusApiItemErrorErrorCode.AssetNotFound,
                "generation_failed" => TranslationStatusApiItemErrorErrorCode.GenerationFailed,
                "translation_failed" => TranslationStatusApiItemErrorErrorCode.TranslationFailed,
                _ => null,
            };
        }
    }
}
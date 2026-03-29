//HintName: G.Models.TranslationStatusApiItemErrorErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationStatusApiItemErrorErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asset_not_found")]
        AssetNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_failed")]
        GenerationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation_failed")]
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
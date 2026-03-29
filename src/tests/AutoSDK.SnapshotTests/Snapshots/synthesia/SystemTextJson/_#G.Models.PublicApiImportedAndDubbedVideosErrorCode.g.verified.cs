//HintName: G.Models.PublicApiImportedAndDubbedVideosErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicApiImportedAndDubbedVideosErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidTargetLanguage,
        /// <summary>
        /// 
        /// </summary>
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        ProcessingError,
        /// <summary>
        /// 
        /// </summary>
        VideoDurationLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicApiImportedAndDubbedVideosErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicApiImportedAndDubbedVideosErrorCode value)
        {
            return value switch
            {
                PublicApiImportedAndDubbedVideosErrorCode.InvalidTargetLanguage => "invalid_target_language",
                PublicApiImportedAndDubbedVideosErrorCode.Moderation => "moderation",
                PublicApiImportedAndDubbedVideosErrorCode.ProcessingError => "processing_error",
                PublicApiImportedAndDubbedVideosErrorCode.VideoDurationLimitReached => "video_duration_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicApiImportedAndDubbedVideosErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_target_language" => PublicApiImportedAndDubbedVideosErrorCode.InvalidTargetLanguage,
                "moderation" => PublicApiImportedAndDubbedVideosErrorCode.Moderation,
                "processing_error" => PublicApiImportedAndDubbedVideosErrorCode.ProcessingError,
                "video_duration_limit_reached" => PublicApiImportedAndDubbedVideosErrorCode.VideoDurationLimitReached,
                _ => null,
            };
        }
    }
}
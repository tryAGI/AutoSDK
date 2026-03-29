//HintName: G.Models.TopicDetectionErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicDetectionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TopicDetectionFailed,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedLanguage,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedListOfTopics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicDetectionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicDetectionErrorType value)
        {
            return value switch
            {
                TopicDetectionErrorType.TopicDetectionFailed => "topic_detection_failed",
                TopicDetectionErrorType.UnsupportedLanguage => "unsupported_language",
                TopicDetectionErrorType.UnsupportedListOfTopics => "unsupported_list_of_topics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicDetectionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "topic_detection_failed" => TopicDetectionErrorType.TopicDetectionFailed,
                "unsupported_language" => TopicDetectionErrorType.UnsupportedLanguage,
                "unsupported_list_of_topics" => TopicDetectionErrorType.UnsupportedListOfTopics,
                _ => null,
            };
        }
    }
}
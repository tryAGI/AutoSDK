//HintName: G.Models.TopicDetectionErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicDetectionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="topic_detection_failed")]
        TopicDetectionFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsupported_language")]
        UnsupportedLanguage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsupported_list_of_topics")]
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
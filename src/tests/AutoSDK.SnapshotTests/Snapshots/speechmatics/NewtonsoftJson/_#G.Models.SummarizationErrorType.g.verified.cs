//HintName: G.Models.SummarizationErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summarization_failed")]
        SummarizationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsupported_language")]
        UnsupportedLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationErrorType value)
        {
            return value switch
            {
                SummarizationErrorType.SummarizationFailed => "summarization_failed",
                SummarizationErrorType.UnsupportedLanguage => "unsupported_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "summarization_failed" => SummarizationErrorType.SummarizationFailed,
                "unsupported_language" => SummarizationErrorType.UnsupportedLanguage,
                _ => null,
            };
        }
    }
}
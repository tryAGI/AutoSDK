//HintName: G.Models.PostSummarizationMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: post_summarization<br/>
    /// Example: post_summarization
    /// </summary>
    public enum PostSummarizationMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        PostSummarization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostSummarizationMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostSummarizationMessageType value)
        {
            return value switch
            {
                PostSummarizationMessageType.PostSummarization => "post_summarization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostSummarizationMessageType? ToEnum(string value)
        {
            return value switch
            {
                "post_summarization" => PostSummarizationMessageType.PostSummarization,
                _ => null,
            };
        }
    }
}
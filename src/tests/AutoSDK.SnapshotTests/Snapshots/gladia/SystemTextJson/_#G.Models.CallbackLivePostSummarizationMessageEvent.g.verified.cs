//HintName: G.Models.CallbackLivePostSummarizationMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.post_summarization<br/>
    /// Example: live.post_summarization
    /// </summary>
    public enum CallbackLivePostSummarizationMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LivePostSummarization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLivePostSummarizationMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLivePostSummarizationMessageEvent value)
        {
            return value switch
            {
                CallbackLivePostSummarizationMessageEvent.LivePostSummarization => "live.post_summarization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLivePostSummarizationMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.post_summarization" => CallbackLivePostSummarizationMessageEvent.LivePostSummarization,
                _ => null,
            };
        }
    }
}
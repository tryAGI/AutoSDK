//HintName: G.Models.CallbackLivePostFinalTranscriptMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.post_final_transcript<br/>
    /// Example: live.post_final_transcript
    /// </summary>
    public enum CallbackLivePostFinalTranscriptMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LivePostFinalTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLivePostFinalTranscriptMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLivePostFinalTranscriptMessageEvent value)
        {
            return value switch
            {
                CallbackLivePostFinalTranscriptMessageEvent.LivePostFinalTranscript => "live.post_final_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLivePostFinalTranscriptMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.post_final_transcript" => CallbackLivePostFinalTranscriptMessageEvent.LivePostFinalTranscript,
                _ => null,
            };
        }
    }
}
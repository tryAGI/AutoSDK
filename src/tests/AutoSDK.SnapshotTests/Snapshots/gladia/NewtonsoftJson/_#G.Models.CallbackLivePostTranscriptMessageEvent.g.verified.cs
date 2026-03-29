//HintName: G.Models.CallbackLivePostTranscriptMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.post_transcript<br/>
    /// Example: live.post_transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLivePostTranscriptMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.post_transcript")]
        LivePostTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLivePostTranscriptMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLivePostTranscriptMessageEvent value)
        {
            return value switch
            {
                CallbackLivePostTranscriptMessageEvent.LivePostTranscript => "live.post_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLivePostTranscriptMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.post_transcript" => CallbackLivePostTranscriptMessageEvent.LivePostTranscript,
                _ => null,
            };
        }
    }
}
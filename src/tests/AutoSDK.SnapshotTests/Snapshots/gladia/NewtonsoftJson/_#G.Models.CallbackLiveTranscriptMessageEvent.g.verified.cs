//HintName: G.Models.CallbackLiveTranscriptMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.transcript<br/>
    /// Example: live.transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLiveTranscriptMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.transcript")]
        LiveTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveTranscriptMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveTranscriptMessageEvent value)
        {
            return value switch
            {
                CallbackLiveTranscriptMessageEvent.LiveTranscript => "live.transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveTranscriptMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.transcript" => CallbackLiveTranscriptMessageEvent.LiveTranscript,
                _ => null,
            };
        }
    }
}
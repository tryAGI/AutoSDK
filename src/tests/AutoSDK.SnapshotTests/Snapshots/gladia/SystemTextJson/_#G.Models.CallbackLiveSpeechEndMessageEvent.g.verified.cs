//HintName: G.Models.CallbackLiveSpeechEndMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.speech_end<br/>
    /// Example: live.speech_end
    /// </summary>
    public enum CallbackLiveSpeechEndMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveSpeechEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveSpeechEndMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveSpeechEndMessageEvent value)
        {
            return value switch
            {
                CallbackLiveSpeechEndMessageEvent.LiveSpeechEnd => "live.speech_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveSpeechEndMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.speech_end" => CallbackLiveSpeechEndMessageEvent.LiveSpeechEnd,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.CallbackLiveSpeechStartMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.speech_start<br/>
    /// Example: live.speech_start
    /// </summary>
    public enum CallbackLiveSpeechStartMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveSpeechStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveSpeechStartMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveSpeechStartMessageEvent value)
        {
            return value switch
            {
                CallbackLiveSpeechStartMessageEvent.LiveSpeechStart => "live.speech_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveSpeechStartMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.speech_start" => CallbackLiveSpeechStartMessageEvent.LiveSpeechStart,
                _ => null,
            };
        }
    }
}
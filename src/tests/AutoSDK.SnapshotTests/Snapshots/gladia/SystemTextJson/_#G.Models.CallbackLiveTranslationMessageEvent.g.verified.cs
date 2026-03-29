//HintName: G.Models.CallbackLiveTranslationMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.translation<br/>
    /// Example: live.translation
    /// </summary>
    public enum CallbackLiveTranslationMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveTranslation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveTranslationMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveTranslationMessageEvent value)
        {
            return value switch
            {
                CallbackLiveTranslationMessageEvent.LiveTranslation => "live.translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveTranslationMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.translation" => CallbackLiveTranslationMessageEvent.LiveTranslation,
                _ => null,
            };
        }
    }
}
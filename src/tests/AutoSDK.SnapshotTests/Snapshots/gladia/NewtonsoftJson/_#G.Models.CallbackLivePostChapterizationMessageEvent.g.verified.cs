//HintName: G.Models.CallbackLivePostChapterizationMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.post_chapterization<br/>
    /// Example: live.post_chapterization
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLivePostChapterizationMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.post_chapterization")]
        LivePostChapterization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLivePostChapterizationMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLivePostChapterizationMessageEvent value)
        {
            return value switch
            {
                CallbackLivePostChapterizationMessageEvent.LivePostChapterization => "live.post_chapterization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLivePostChapterizationMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.post_chapterization" => CallbackLivePostChapterizationMessageEvent.LivePostChapterization,
                _ => null,
            };
        }
    }
}
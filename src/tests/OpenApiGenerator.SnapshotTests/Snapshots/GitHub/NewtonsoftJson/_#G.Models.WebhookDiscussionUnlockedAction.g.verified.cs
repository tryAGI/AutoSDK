//HintName: G.Models.WebhookDiscussionUnlockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDiscussionUnlockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unlocked")]
        Unlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionUnlockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionUnlockedAction value)
        {
            return value switch
            {
                WebhookDiscussionUnlockedAction.Unlocked => "unlocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionUnlockedAction? ToEnum(string value)
        {
            return value switch
            {
                "unlocked" => WebhookDiscussionUnlockedAction.Unlocked,
                _ => null,
            };
        }
    }
}
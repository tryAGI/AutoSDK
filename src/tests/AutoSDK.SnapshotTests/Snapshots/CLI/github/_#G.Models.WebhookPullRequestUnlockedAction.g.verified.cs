//HintName: G.Models.WebhookPullRequestUnlockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnlockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedAction value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedAction.Unlocked => "unlocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedAction? ToEnum(string value)
        {
            return value switch
            {
                "unlocked" => WebhookPullRequestUnlockedAction.Unlocked,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestMilestonedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestMilestonedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Milestoned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestMilestonedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestMilestonedAction value)
        {
            return value switch
            {
                WebhookPullRequestMilestonedAction.Milestoned => "milestoned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestMilestonedAction ToEnum(string value)
        {
            return value switch
            {
                "milestoned" => WebhookPullRequestMilestonedAction.Milestoned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestDemilestonedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDemilestonedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Demilestoned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDemilestonedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDemilestonedAction value)
        {
            return value switch
            {
                WebhookPullRequestDemilestonedAction.Demilestoned => "demilestoned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDemilestonedAction ToEnum(string value)
        {
            return value switch
            {
                "demilestoned" => WebhookPullRequestDemilestonedAction.Demilestoned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
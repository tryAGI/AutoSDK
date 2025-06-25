//HintName: G.Models.WebhookPullRequestReviewThreadResolvedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedAction value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedAction.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedAction? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewThreadResolvedAction.Resolved,
                _ => null,
            };
        }
    }
}
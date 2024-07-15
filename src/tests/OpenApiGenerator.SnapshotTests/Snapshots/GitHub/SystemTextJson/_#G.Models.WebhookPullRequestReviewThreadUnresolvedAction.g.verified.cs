//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unresolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedAction value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedAction.Unresolved => "unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedAction? ToEnum(string value)
        {
            return value switch
            {
                "unresolved" => WebhookPullRequestReviewThreadUnresolvedAction.Unresolved,
                _ => null,
            };
        }
    }
}
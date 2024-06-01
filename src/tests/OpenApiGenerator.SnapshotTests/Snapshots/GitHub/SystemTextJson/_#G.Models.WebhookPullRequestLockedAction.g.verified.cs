//HintName: G.Models.WebhookPullRequestLockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Locked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedAction value)
        {
            return value switch
            {
                WebhookPullRequestLockedAction.Locked => "locked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedAction ToEnum(string value)
        {
            return value switch
            {
                "locked" => WebhookPullRequestLockedAction.Locked,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
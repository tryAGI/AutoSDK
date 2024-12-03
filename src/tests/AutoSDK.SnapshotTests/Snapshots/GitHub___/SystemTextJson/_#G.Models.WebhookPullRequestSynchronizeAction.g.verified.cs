//HintName: G.Models.WebhookPullRequestSynchronizeAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizeAction
    {
        /// <summary>
        /// 
        /// </summary>
        Synchronize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizeAction value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizeAction.Synchronize => "synchronize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizeAction? ToEnum(string value)
        {
            return value switch
            {
                "synchronize" => WebhookPullRequestSynchronizeAction.Synchronize,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestOpenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestOpenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Opened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestOpenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestOpenedAction value)
        {
            return value switch
            {
                WebhookPullRequestOpenedAction.Opened => "opened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestOpenedAction ToEnum(string value)
        {
            return value switch
            {
                "opened" => WebhookPullRequestOpenedAction.Opened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
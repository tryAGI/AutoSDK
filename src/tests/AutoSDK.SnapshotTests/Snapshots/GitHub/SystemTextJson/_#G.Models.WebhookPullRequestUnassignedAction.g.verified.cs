//HintName: G.Models.WebhookPullRequestUnassignedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unassigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedAction value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedAction.Unassigned => "unassigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedAction? ToEnum(string value)
        {
            return value switch
            {
                "unassigned" => WebhookPullRequestUnassignedAction.Unassigned,
                _ => null,
            };
        }
    }
}
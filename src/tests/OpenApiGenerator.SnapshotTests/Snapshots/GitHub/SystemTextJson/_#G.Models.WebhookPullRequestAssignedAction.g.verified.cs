//HintName: G.Models.WebhookPullRequestAssignedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Assigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAssignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedAction value)
        {
            return value switch
            {
                WebhookPullRequestAssignedAction.Assigned => "assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedAction ToEnum(string value)
        {
            return value switch
            {
                "assigned" => WebhookPullRequestAssignedAction.Assigned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
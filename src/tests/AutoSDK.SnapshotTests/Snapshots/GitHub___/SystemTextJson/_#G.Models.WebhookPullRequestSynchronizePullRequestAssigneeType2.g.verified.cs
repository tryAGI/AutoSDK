//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestAssigneeType2
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestAssigneeType2.User => "User",
                WebhookPullRequestSynchronizePullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}
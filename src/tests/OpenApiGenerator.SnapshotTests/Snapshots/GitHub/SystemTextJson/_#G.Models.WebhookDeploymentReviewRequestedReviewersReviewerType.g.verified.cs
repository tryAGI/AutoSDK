//HintName: G.Models.WebhookDeploymentReviewRequestedReviewersReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedReviewersReviewerType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRequestedReviewersReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedReviewersReviewerType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedReviewersReviewerType.Bot => "Bot",
                WebhookDeploymentReviewRequestedReviewersReviewerType.User => "User",
                WebhookDeploymentReviewRequestedReviewersReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedReviewersReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRequestedReviewersReviewerType.Bot,
                "User" => WebhookDeploymentReviewRequestedReviewersReviewerType.User,
                "Organization" => WebhookDeploymentReviewRequestedReviewersReviewerType.Organization,
                _ => null,
            };
        }
    }
}
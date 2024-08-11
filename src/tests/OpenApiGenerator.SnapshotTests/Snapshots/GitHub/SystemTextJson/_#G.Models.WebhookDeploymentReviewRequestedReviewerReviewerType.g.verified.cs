//HintName: G.Models.WebhookDeploymentReviewRequestedReviewerReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedReviewerReviewerType
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
    public static class WebhookDeploymentReviewRequestedReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedReviewerReviewerType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedReviewerReviewerType.Bot => "Bot",
                WebhookDeploymentReviewRequestedReviewerReviewerType.User => "User",
                WebhookDeploymentReviewRequestedReviewerReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRequestedReviewerReviewerType.Bot,
                "User" => WebhookDeploymentReviewRequestedReviewerReviewerType.User,
                "Organization" => WebhookDeploymentReviewRequestedReviewerReviewerType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookDeploymentReviewApprovedReviewersReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewApprovedReviewersReviewerType
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
    public static class WebhookDeploymentReviewApprovedReviewersReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedReviewersReviewerType value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedReviewersReviewerType.Bot => "Bot",
                WebhookDeploymentReviewApprovedReviewersReviewerType.User => "User",
                WebhookDeploymentReviewApprovedReviewersReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedReviewersReviewerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewApprovedReviewersReviewerType.Bot,
                "User" => WebhookDeploymentReviewApprovedReviewersReviewerType.User,
                "Organization" => WebhookDeploymentReviewApprovedReviewersReviewerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookDeploymentReviewRejectedReviewersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRejectedReviewersType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRejectedReviewersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedReviewersType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedReviewersType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedReviewersType? ToEnum(string value)
        {
            return value switch
            {
                "User" => WebhookDeploymentReviewRejectedReviewersType.User,
                _ => null,
            };
        }
    }
}
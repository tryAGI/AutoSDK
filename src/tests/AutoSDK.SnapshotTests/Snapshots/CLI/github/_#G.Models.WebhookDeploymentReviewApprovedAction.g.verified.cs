//HintName: G.Models.WebhookDeploymentReviewApprovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewApprovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedAction value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedAction.Approved => "approved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedAction? ToEnum(string value)
        {
            return value switch
            {
                "approved" => WebhookDeploymentReviewApprovedAction.Approved,
                _ => null,
            };
        }
    }
}
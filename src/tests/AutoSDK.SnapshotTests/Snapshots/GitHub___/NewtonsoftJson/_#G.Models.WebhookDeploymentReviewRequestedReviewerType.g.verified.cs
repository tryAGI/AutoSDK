//HintName: G.Models.WebhookDeploymentReviewRequestedReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRequestedReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Team")]
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRequestedReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedReviewerType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedReviewerType.User => "User",
                WebhookDeploymentReviewRequestedReviewerType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "User" => WebhookDeploymentReviewRequestedReviewerType.User,
                "Team" => WebhookDeploymentReviewRequestedReviewerType.Team,
                _ => null,
            };
        }
    }
}
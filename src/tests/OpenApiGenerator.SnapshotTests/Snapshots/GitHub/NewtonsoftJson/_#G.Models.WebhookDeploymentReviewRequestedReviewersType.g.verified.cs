//HintName: G.Models.WebhookDeploymentReviewRequestedReviewersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRequestedReviewersType
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
    public static class WebhookDeploymentReviewRequestedReviewersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedReviewersType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedReviewersType.User => "User",
                WebhookDeploymentReviewRequestedReviewersType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedReviewersType? ToEnum(string value)
        {
            return value switch
            {
                "User" => WebhookDeploymentReviewRequestedReviewersType.User,
                "Team" => WebhookDeploymentReviewRequestedReviewersType.Team,
                _ => null,
            };
        }
    }
}
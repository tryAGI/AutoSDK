//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewApprovedWorkflowRunActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewApprovedWorkflowRunActorType.Organization => "Organization",
                WebhookDeploymentReviewApprovedWorkflowRunActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewApprovedWorkflowRunActorType.Bot,
                "Organization" => WebhookDeploymentReviewApprovedWorkflowRunActorType.Organization,
                "User" => WebhookDeploymentReviewApprovedWorkflowRunActorType.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.User => "User",
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
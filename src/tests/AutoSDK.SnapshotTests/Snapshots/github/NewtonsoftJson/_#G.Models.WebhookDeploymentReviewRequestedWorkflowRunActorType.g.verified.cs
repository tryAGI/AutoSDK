//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRequestedWorkflowRunActorType
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
    public static class WebhookDeploymentReviewRequestedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewRequestedWorkflowRunActorType.Organization => "Organization",
                WebhookDeploymentReviewRequestedWorkflowRunActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRequestedWorkflowRunActorType.Bot,
                "Organization" => WebhookDeploymentReviewRequestedWorkflowRunActorType.Organization,
                "User" => WebhookDeploymentReviewRequestedWorkflowRunActorType.User,
                _ => null,
            };
        }
    }
}
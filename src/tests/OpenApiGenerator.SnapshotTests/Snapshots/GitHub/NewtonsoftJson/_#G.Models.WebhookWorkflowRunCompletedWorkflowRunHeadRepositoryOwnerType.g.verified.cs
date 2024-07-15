//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
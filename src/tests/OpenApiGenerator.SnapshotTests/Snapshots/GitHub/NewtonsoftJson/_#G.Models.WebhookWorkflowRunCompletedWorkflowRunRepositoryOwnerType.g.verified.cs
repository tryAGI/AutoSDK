//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunCompletedWorkflowRunActorType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunActorType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunActorType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunActorType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunActorType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}
﻿//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.User => "User",
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
﻿//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType
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
    public static class WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.User => "User",
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
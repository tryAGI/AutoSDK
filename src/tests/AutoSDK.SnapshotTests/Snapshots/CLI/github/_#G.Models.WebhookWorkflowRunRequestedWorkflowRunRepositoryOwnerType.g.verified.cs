﻿//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.User => "User",
                WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunRequestedWorkflowRunRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
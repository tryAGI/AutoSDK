﻿//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType
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
        public static WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
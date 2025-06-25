﻿//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunTriggeringActorType.Organization,
                _ => null,
            };
        }
    }
}
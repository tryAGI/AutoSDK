﻿//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedWorkflowRunActorType
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
    public static class WebhookDeploymentCreatedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentCreatedWorkflowRunActorType.User => "User",
                WebhookDeploymentCreatedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedWorkflowRunActorType.Bot,
                "User" => WebhookDeploymentCreatedWorkflowRunActorType.User,
                "Organization" => WebhookDeploymentCreatedWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}
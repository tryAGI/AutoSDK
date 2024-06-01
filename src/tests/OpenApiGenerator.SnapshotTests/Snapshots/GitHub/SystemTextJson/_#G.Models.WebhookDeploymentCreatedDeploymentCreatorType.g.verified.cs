//HintName: G.Models.WebhookDeploymentCreatedDeploymentCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentCreatorType
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
    public static class WebhookDeploymentCreatedDeploymentCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentCreatorType value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentCreatorType.Bot => "Bot",
                WebhookDeploymentCreatedDeploymentCreatorType.User => "User",
                WebhookDeploymentCreatedDeploymentCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedDeploymentCreatorType.Bot,
                "User" => WebhookDeploymentCreatedDeploymentCreatorType.User,
                "Organization" => WebhookDeploymentCreatedDeploymentCreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
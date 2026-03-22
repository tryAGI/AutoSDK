//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedDeploymentCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentCreatorType value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentCreatorType.Bot => "Bot",
                WebhookDeploymentStatusCreatedDeploymentCreatorType.Organization => "Organization",
                WebhookDeploymentStatusCreatedDeploymentCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedDeploymentCreatorType.Bot,
                "Organization" => WebhookDeploymentStatusCreatedDeploymentCreatorType.Organization,
                "User" => WebhookDeploymentStatusCreatedDeploymentCreatorType.User,
                _ => null,
            };
        }
    }
}
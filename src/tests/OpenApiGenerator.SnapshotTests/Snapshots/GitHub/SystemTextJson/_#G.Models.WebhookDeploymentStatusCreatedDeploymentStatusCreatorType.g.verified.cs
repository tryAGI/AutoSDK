//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentStatusCreatorType
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
    public static class WebhookDeploymentStatusCreatedDeploymentStatusCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusCreatorType value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Bot => "Bot",
                WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.User => "User",
                WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Bot,
                "User" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.User,
                "Organization" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
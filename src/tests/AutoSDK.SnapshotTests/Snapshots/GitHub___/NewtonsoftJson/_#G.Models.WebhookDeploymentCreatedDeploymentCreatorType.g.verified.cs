//HintName: G.Models.WebhookDeploymentCreatedDeploymentCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedDeploymentCreatorType
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
        public static WebhookDeploymentCreatedDeploymentCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedDeploymentCreatorType.Bot,
                "User" => WebhookDeploymentCreatedDeploymentCreatorType.User,
                "Organization" => WebhookDeploymentCreatedDeploymentCreatorType.Organization,
                _ => null,
            };
        }
    }
}
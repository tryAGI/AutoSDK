//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentStatusCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
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
                WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Organization => "Organization",
                WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Bot,
                "Organization" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.Organization,
                "User" => WebhookDeploymentStatusCreatedDeploymentStatusCreatorType.User,
                _ => null,
            };
        }
    }
}
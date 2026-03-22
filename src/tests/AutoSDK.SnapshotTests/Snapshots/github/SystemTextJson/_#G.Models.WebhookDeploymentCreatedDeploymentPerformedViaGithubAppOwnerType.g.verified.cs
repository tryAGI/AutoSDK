//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}
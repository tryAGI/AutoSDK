//HintName: G.Models.WebhookTeamCreatedRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamCreatedRepositoryOwnerType
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
    public static class WebhookTeamCreatedRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamCreatedRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookTeamCreatedRepositoryOwnerType.Bot => "Bot",
                WebhookTeamCreatedRepositoryOwnerType.Organization => "Organization",
                WebhookTeamCreatedRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamCreatedRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamCreatedRepositoryOwnerType.Bot,
                "Organization" => WebhookTeamCreatedRepositoryOwnerType.Organization,
                "User" => WebhookTeamCreatedRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}
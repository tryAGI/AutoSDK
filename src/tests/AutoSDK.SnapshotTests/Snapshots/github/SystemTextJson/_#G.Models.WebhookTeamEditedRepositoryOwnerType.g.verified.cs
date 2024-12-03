//HintName: G.Models.WebhookTeamEditedRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamEditedRepositoryOwnerType
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
    public static class WebhookTeamEditedRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamEditedRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookTeamEditedRepositoryOwnerType.Bot => "Bot",
                WebhookTeamEditedRepositoryOwnerType.User => "User",
                WebhookTeamEditedRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamEditedRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamEditedRepositoryOwnerType.Bot,
                "User" => WebhookTeamEditedRepositoryOwnerType.User,
                "Organization" => WebhookTeamEditedRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
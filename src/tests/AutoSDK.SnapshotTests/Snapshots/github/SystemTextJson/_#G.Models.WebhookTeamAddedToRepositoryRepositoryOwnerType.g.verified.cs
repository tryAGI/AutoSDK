//HintName: G.Models.WebhookTeamAddedToRepositoryRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamAddedToRepositoryRepositoryOwnerType
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
    public static class WebhookTeamAddedToRepositoryRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamAddedToRepositoryRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookTeamAddedToRepositoryRepositoryOwnerType.Bot => "Bot",
                WebhookTeamAddedToRepositoryRepositoryOwnerType.Organization => "Organization",
                WebhookTeamAddedToRepositoryRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamAddedToRepositoryRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamAddedToRepositoryRepositoryOwnerType.Bot,
                "Organization" => WebhookTeamAddedToRepositoryRepositoryOwnerType.Organization,
                "User" => WebhookTeamAddedToRepositoryRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookTeamDeletedRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamDeletedRepositoryOwnerType
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
    public static class WebhookTeamDeletedRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamDeletedRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookTeamDeletedRepositoryOwnerType.Bot => "Bot",
                WebhookTeamDeletedRepositoryOwnerType.Organization => "Organization",
                WebhookTeamDeletedRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamDeletedRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamDeletedRepositoryOwnerType.Bot,
                "Organization" => WebhookTeamDeletedRepositoryOwnerType.Organization,
                "User" => WebhookTeamDeletedRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}
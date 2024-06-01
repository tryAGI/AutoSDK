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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookTeamDeletedRepositoryOwnerType.User => "User",
                WebhookTeamDeletedRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamDeletedRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamDeletedRepositoryOwnerType.Bot,
                "User" => WebhookTeamDeletedRepositoryOwnerType.User,
                "Organization" => WebhookTeamDeletedRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
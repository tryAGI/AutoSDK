//HintName: G.Models.WebhookTeamRemovedFromRepositoryRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamRemovedFromRepositoryRepositoryOwnerType
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
    public static class WebhookTeamRemovedFromRepositoryRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamRemovedFromRepositoryRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookTeamRemovedFromRepositoryRepositoryOwnerType.Bot => "Bot",
                WebhookTeamRemovedFromRepositoryRepositoryOwnerType.Organization => "Organization",
                WebhookTeamRemovedFromRepositoryRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamRemovedFromRepositoryRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamRemovedFromRepositoryRepositoryOwnerType.Bot,
                "Organization" => WebhookTeamRemovedFromRepositoryRepositoryOwnerType.Organization,
                "User" => WebhookTeamRemovedFromRepositoryRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}
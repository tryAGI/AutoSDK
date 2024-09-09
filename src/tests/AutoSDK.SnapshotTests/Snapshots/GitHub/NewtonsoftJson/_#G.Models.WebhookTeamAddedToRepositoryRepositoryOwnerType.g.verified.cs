//HintName: G.Models.WebhookTeamAddedToRepositoryRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamAddedToRepositoryRepositoryOwnerType
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
                WebhookTeamAddedToRepositoryRepositoryOwnerType.User => "User",
                WebhookTeamAddedToRepositoryRepositoryOwnerType.Organization => "Organization",
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
                "User" => WebhookTeamAddedToRepositoryRepositoryOwnerType.User,
                "Organization" => WebhookTeamAddedToRepositoryRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookTeamEditedRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamEditedRepositoryOwnerType
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
        public static WebhookTeamEditedRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookTeamEditedRepositoryOwnerType.Bot,
                "User" => WebhookTeamEditedRepositoryOwnerType.User,
                "Organization" => WebhookTeamEditedRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookRepositoryTransferredChangesOwnerFromUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookRepositoryTransferredChangesOwnerFromUserType
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
    public static class WebhookRepositoryTransferredChangesOwnerFromUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryTransferredChangesOwnerFromUserType value)
        {
            return value switch
            {
                WebhookRepositoryTransferredChangesOwnerFromUserType.Bot => "Bot",
                WebhookRepositoryTransferredChangesOwnerFromUserType.Organization => "Organization",
                WebhookRepositoryTransferredChangesOwnerFromUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryTransferredChangesOwnerFromUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookRepositoryTransferredChangesOwnerFromUserType.Bot,
                "Organization" => WebhookRepositoryTransferredChangesOwnerFromUserType.Organization,
                "User" => WebhookRepositoryTransferredChangesOwnerFromUserType.User,
                _ => null,
            };
        }
    }
}
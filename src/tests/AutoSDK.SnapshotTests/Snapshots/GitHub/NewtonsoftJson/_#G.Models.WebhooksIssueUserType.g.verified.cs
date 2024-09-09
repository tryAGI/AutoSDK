//HintName: G.Models.WebhooksIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueUserType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueUserType value)
        {
            return value switch
            {
                WebhooksIssueUserType.Bot => "Bot",
                WebhooksIssueUserType.User => "User",
                WebhooksIssueUserType.Organization => "Organization",
                WebhooksIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueUserType.Bot,
                "User" => WebhooksIssueUserType.User,
                "Organization" => WebhooksIssueUserType.Organization,
                "Mannequin" => WebhooksIssueUserType.Mannequin,
                _ => null,
            };
        }
    }
}
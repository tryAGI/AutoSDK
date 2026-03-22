//HintName: G.Models.WebhookStatusCommitAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStatusCommitAuthorType
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
    public static class WebhookStatusCommitAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusCommitAuthorType value)
        {
            return value switch
            {
                WebhookStatusCommitAuthorType.Bot => "Bot",
                WebhookStatusCommitAuthorType.Organization => "Organization",
                WebhookStatusCommitAuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusCommitAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookStatusCommitAuthorType.Bot,
                "Organization" => WebhookStatusCommitAuthorType.Organization,
                "User" => WebhookStatusCommitAuthorType.User,
                _ => null,
            };
        }
    }
}
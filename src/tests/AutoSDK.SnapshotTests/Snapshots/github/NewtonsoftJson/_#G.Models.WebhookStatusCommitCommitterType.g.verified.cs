//HintName: G.Models.WebhookStatusCommitCommitterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStatusCommitCommitterType
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
    public static class WebhookStatusCommitCommitterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusCommitCommitterType value)
        {
            return value switch
            {
                WebhookStatusCommitCommitterType.Bot => "Bot",
                WebhookStatusCommitCommitterType.Organization => "Organization",
                WebhookStatusCommitCommitterType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusCommitCommitterType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookStatusCommitCommitterType.Bot,
                "Organization" => WebhookStatusCommitCommitterType.Organization,
                "User" => WebhookStatusCommitCommitterType.User,
                _ => null,
            };
        }
    }
}
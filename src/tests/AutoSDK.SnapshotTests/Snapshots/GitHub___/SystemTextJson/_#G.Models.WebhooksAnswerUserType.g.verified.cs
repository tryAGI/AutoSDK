//HintName: G.Models.WebhooksAnswerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksAnswerUserType
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
    public static class WebhooksAnswerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAnswerUserType value)
        {
            return value switch
            {
                WebhooksAnswerUserType.Bot => "Bot",
                WebhooksAnswerUserType.User => "User",
                WebhooksAnswerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAnswerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksAnswerUserType.Bot,
                "User" => WebhooksAnswerUserType.User,
                "Organization" => WebhooksAnswerUserType.Organization,
                _ => null,
            };
        }
    }
}
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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhooksAnswerUserType.Organization => "Organization",
                WebhooksAnswerUserType.User => "User",
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
                "Organization" => WebhooksAnswerUserType.Organization,
                "User" => WebhooksAnswerUserType.User,
                _ => null,
            };
        }
    }
}
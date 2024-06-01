//HintName: G.Models.WebhookStatusCommitCommitterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookStatusCommitCommitterType
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
                WebhookStatusCommitCommitterType.User => "User",
                WebhookStatusCommitCommitterType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusCommitCommitterType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookStatusCommitCommitterType.Bot,
                "User" => WebhookStatusCommitCommitterType.User,
                "Organization" => WebhookStatusCommitCommitterType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
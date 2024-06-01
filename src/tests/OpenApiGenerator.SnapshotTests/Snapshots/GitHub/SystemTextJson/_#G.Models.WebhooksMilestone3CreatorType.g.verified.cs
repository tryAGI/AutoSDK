//HintName: G.Models.WebhooksMilestone3CreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksMilestone3CreatorType
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
    public static class WebhooksMilestone3CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMilestone3CreatorType value)
        {
            return value switch
            {
                WebhooksMilestone3CreatorType.Bot => "Bot",
                WebhooksMilestone3CreatorType.User => "User",
                WebhooksMilestone3CreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMilestone3CreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksMilestone3CreatorType.Bot,
                "User" => WebhooksMilestone3CreatorType.User,
                "Organization" => WebhooksMilestone3CreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
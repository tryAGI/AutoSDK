//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppOwnerType
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppOwnerType value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Bot => "Bot",
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User => "User",
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Bot,
                "User" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User,
                "Organization" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
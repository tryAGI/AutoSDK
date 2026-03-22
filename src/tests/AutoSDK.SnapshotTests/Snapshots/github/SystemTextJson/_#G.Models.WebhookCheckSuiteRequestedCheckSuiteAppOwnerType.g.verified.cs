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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization => "Organization",
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Bot,
                "Organization" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization,
                "User" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User,
                _ => null,
            };
        }
    }
}
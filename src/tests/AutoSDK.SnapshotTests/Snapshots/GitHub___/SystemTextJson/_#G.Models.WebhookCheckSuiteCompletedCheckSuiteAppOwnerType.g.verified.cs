//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppOwnerType
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppOwnerType value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Bot => "Bot",
                WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.User => "User",
                WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Bot,
                "User" => WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.User,
                "Organization" => WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
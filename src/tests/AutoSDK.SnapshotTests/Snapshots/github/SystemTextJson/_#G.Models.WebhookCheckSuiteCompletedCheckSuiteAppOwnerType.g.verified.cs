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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Organization => "Organization",
                WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.User => "User",
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
                "Organization" => WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.Organization,
                "User" => WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.User,
                _ => null,
            };
        }
    }
}
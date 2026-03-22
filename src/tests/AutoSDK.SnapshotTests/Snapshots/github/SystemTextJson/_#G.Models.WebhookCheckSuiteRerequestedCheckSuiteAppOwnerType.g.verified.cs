//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.Bot => "Bot",
                WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.Organization => "Organization",
                WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.Bot,
                "Organization" => WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.Organization,
                "User" => WebhookCheckSuiteRerequestedCheckSuiteAppOwnerType.User,
                _ => null,
            };
        }
    }
}
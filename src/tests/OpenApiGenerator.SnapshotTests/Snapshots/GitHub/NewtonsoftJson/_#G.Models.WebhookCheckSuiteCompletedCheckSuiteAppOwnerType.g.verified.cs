//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteCompletedCheckSuiteAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
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
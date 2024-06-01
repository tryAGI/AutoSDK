//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
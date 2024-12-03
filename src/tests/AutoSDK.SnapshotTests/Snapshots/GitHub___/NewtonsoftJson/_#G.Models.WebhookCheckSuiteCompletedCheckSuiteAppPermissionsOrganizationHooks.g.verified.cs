//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks.Write,
                _ => null,
            };
        }
    }
}
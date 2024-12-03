//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatusesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses.Write,
                _ => null,
            };
        }
    }
}
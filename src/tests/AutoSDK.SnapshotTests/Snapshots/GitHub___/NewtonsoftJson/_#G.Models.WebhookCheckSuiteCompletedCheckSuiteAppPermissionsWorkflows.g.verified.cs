//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows.Write,
                _ => null,
            };
        }
    }
}
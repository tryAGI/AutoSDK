//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Write => "write",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Write,
                "admin" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
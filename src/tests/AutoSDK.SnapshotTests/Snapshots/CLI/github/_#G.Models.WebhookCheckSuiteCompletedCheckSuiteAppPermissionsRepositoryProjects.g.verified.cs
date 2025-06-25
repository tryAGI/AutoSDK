//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Write => "write",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Write,
                "admin" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects.Admin,
                _ => null,
            };
        }
    }
}
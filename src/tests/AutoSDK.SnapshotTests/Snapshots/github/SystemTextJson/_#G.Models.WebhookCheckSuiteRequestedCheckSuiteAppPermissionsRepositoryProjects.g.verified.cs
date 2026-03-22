//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Admin => "admin",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Admin,
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects.Write,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.CodeSecurityConfigurationRepositoriesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attachment status of the code security configuration on the repository.
    /// </summary>
    public enum CodeSecurityConfigurationRepositoriesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Attached,
        /// <summary>
        /// 
        /// </summary>
        Attaching,
        /// <summary>
        /// 
        /// </summary>
        Detached,
        /// <summary>
        /// 
        /// </summary>
        Removed,
        /// <summary>
        /// 
        /// </summary>
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Updating,
        /// <summary>
        /// 
        /// </summary>
        RemovedByEnterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationRepositoriesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationRepositoriesStatus value)
        {
            return value switch
            {
                CodeSecurityConfigurationRepositoriesStatus.Attached => "attached",
                CodeSecurityConfigurationRepositoriesStatus.Attaching => "attaching",
                CodeSecurityConfigurationRepositoriesStatus.Detached => "detached",
                CodeSecurityConfigurationRepositoriesStatus.Removed => "removed",
                CodeSecurityConfigurationRepositoriesStatus.Enforced => "enforced",
                CodeSecurityConfigurationRepositoriesStatus.Failed => "failed",
                CodeSecurityConfigurationRepositoriesStatus.Updating => "updating",
                CodeSecurityConfigurationRepositoriesStatus.RemovedByEnterprise => "removed_by_enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationRepositoriesStatus? ToEnum(string value)
        {
            return value switch
            {
                "attached" => CodeSecurityConfigurationRepositoriesStatus.Attached,
                "attaching" => CodeSecurityConfigurationRepositoriesStatus.Attaching,
                "detached" => CodeSecurityConfigurationRepositoriesStatus.Detached,
                "removed" => CodeSecurityConfigurationRepositoriesStatus.Removed,
                "enforced" => CodeSecurityConfigurationRepositoriesStatus.Enforced,
                "failed" => CodeSecurityConfigurationRepositoriesStatus.Failed,
                "updating" => CodeSecurityConfigurationRepositoriesStatus.Updating,
                "removed_by_enterprise" => CodeSecurityConfigurationRepositoriesStatus.RemovedByEnterprise,
                _ => null,
            };
        }
    }
}
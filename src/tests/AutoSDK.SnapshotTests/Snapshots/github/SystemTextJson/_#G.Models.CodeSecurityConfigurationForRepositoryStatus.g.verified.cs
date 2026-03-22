//HintName: G.Models.CodeSecurityConfigurationForRepositoryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attachment status of the code security configuration on the repository.
    /// </summary>
    public enum CodeSecurityConfigurationForRepositoryStatus
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
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Removed,
        /// <summary>
        /// 
        /// </summary>
        RemovedByEnterprise,
        /// <summary>
        /// 
        /// </summary>
        Updating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationForRepositoryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationForRepositoryStatus value)
        {
            return value switch
            {
                CodeSecurityConfigurationForRepositoryStatus.Attached => "attached",
                CodeSecurityConfigurationForRepositoryStatus.Attaching => "attaching",
                CodeSecurityConfigurationForRepositoryStatus.Detached => "detached",
                CodeSecurityConfigurationForRepositoryStatus.Enforced => "enforced",
                CodeSecurityConfigurationForRepositoryStatus.Failed => "failed",
                CodeSecurityConfigurationForRepositoryStatus.Removed => "removed",
                CodeSecurityConfigurationForRepositoryStatus.RemovedByEnterprise => "removed_by_enterprise",
                CodeSecurityConfigurationForRepositoryStatus.Updating => "updating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationForRepositoryStatus? ToEnum(string value)
        {
            return value switch
            {
                "attached" => CodeSecurityConfigurationForRepositoryStatus.Attached,
                "attaching" => CodeSecurityConfigurationForRepositoryStatus.Attaching,
                "detached" => CodeSecurityConfigurationForRepositoryStatus.Detached,
                "enforced" => CodeSecurityConfigurationForRepositoryStatus.Enforced,
                "failed" => CodeSecurityConfigurationForRepositoryStatus.Failed,
                "removed" => CodeSecurityConfigurationForRepositoryStatus.Removed,
                "removed_by_enterprise" => CodeSecurityConfigurationForRepositoryStatus.RemovedByEnterprise,
                "updating" => CodeSecurityConfigurationForRepositoryStatus.Updating,
                _ => null,
            };
        }
    }
}
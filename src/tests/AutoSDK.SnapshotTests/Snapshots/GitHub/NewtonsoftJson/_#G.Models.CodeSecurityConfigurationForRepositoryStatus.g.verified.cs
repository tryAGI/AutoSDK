//HintName: G.Models.CodeSecurityConfigurationForRepositoryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attachment status of the code security configuration on the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationForRepositoryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="attached")]
        Attached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="attaching")]
        Attaching,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detached")]
        Detached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
        Removed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enforced")]
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updating")]
        Updating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed_by_enterprise")]
        RemovedByEnterprise,
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
                CodeSecurityConfigurationForRepositoryStatus.Removed => "removed",
                CodeSecurityConfigurationForRepositoryStatus.Enforced => "enforced",
                CodeSecurityConfigurationForRepositoryStatus.Failed => "failed",
                CodeSecurityConfigurationForRepositoryStatus.Updating => "updating",
                CodeSecurityConfigurationForRepositoryStatus.RemovedByEnterprise => "removed_by_enterprise",
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
                "removed" => CodeSecurityConfigurationForRepositoryStatus.Removed,
                "enforced" => CodeSecurityConfigurationForRepositoryStatus.Enforced,
                "failed" => CodeSecurityConfigurationForRepositoryStatus.Failed,
                "updating" => CodeSecurityConfigurationForRepositoryStatus.Updating,
                "removed_by_enterprise" => CodeSecurityConfigurationForRepositoryStatus.RemovedByEnterprise,
                _ => null,
            };
        }
    }
}
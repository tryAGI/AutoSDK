//HintName: G.Models.ProjectOrganizationPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectOrganizationPermission
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectOrganizationPermission value)
        {
            return value switch
            {
                ProjectOrganizationPermission.Read => "read",
                ProjectOrganizationPermission.Write => "write",
                ProjectOrganizationPermission.Admin => "admin",
                ProjectOrganizationPermission.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "read" => ProjectOrganizationPermission.Read,
                "write" => ProjectOrganizationPermission.Write,
                "admin" => ProjectOrganizationPermission.Admin,
                "none" => ProjectOrganizationPermission.None,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RepositoryInvitationPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission associated with the invitation.<br/>
    /// Example: read
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryInvitationPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintain")]
        Maintain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
        Triage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryInvitationPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryInvitationPermissions value)
        {
            return value switch
            {
                RepositoryInvitationPermissions.Admin => "admin",
                RepositoryInvitationPermissions.Maintain => "maintain",
                RepositoryInvitationPermissions.Read => "read",
                RepositoryInvitationPermissions.Triage => "triage",
                RepositoryInvitationPermissions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryInvitationPermissions? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RepositoryInvitationPermissions.Admin,
                "maintain" => RepositoryInvitationPermissions.Maintain,
                "read" => RepositoryInvitationPermissions.Read,
                "triage" => RepositoryInvitationPermissions.Triage,
                "write" => RepositoryInvitationPermissions.Write,
                _ => null,
            };
        }
    }
}
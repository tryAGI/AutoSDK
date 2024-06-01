//HintName: G.Models.RepositoryInvitationPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission associated with the invitation.
    /// <br/>Example: read
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryInvitationPermissions
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
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
        Triage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintain")]
        Maintain,
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
                RepositoryInvitationPermissions.Read => "read",
                RepositoryInvitationPermissions.Write => "write",
                RepositoryInvitationPermissions.Admin => "admin",
                RepositoryInvitationPermissions.Triage => "triage",
                RepositoryInvitationPermissions.Maintain => "maintain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryInvitationPermissions ToEnum(string value)
        {
            return value switch
            {
                "read" => RepositoryInvitationPermissions.Read,
                "write" => RepositoryInvitationPermissions.Write,
                "admin" => RepositoryInvitationPermissions.Admin,
                "triage" => RepositoryInvitationPermissions.Triage,
                "maintain" => RepositoryInvitationPermissions.Maintain,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.ReposUpdateInvitationRequestPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions that the associated user will have on the repository. Valid values are `read`, `write`, `maintain`, `triage`, and `admin`.
    /// </summary>
    public enum ReposUpdateInvitationRequestPermissions
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
        Maintain,
        /// <summary>
        /// 
        /// </summary>
        Triage,
        /// <summary>
        /// 
        /// </summary>
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateInvitationRequestPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateInvitationRequestPermissions value)
        {
            return value switch
            {
                ReposUpdateInvitationRequestPermissions.Read => "read",
                ReposUpdateInvitationRequestPermissions.Write => "write",
                ReposUpdateInvitationRequestPermissions.Maintain => "maintain",
                ReposUpdateInvitationRequestPermissions.Triage => "triage",
                ReposUpdateInvitationRequestPermissions.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInvitationRequestPermissions ToEnum(string value)
        {
            return value switch
            {
                "read" => ReposUpdateInvitationRequestPermissions.Read,
                "write" => ReposUpdateInvitationRequestPermissions.Write,
                "maintain" => ReposUpdateInvitationRequestPermissions.Maintain,
                "triage" => ReposUpdateInvitationRequestPermissions.Triage,
                "admin" => ReposUpdateInvitationRequestPermissions.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
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
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Maintain,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Triage,
        /// <summary>
        /// 
        /// </summary>
        Write,
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
                ReposUpdateInvitationRequestPermissions.Admin => "admin",
                ReposUpdateInvitationRequestPermissions.Maintain => "maintain",
                ReposUpdateInvitationRequestPermissions.Read => "read",
                ReposUpdateInvitationRequestPermissions.Triage => "triage",
                ReposUpdateInvitationRequestPermissions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateInvitationRequestPermissions? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ReposUpdateInvitationRequestPermissions.Admin,
                "maintain" => ReposUpdateInvitationRequestPermissions.Maintain,
                "read" => ReposUpdateInvitationRequestPermissions.Read,
                "triage" => ReposUpdateInvitationRequestPermissions.Triage,
                "write" => ReposUpdateInvitationRequestPermissions.Write,
                _ => null,
            };
        }
    }
}
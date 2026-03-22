//HintName: G.Models.ReposListCollaboratorsPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListCollaboratorsPermission
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
        Pull,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Triage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListCollaboratorsPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListCollaboratorsPermission value)
        {
            return value switch
            {
                ReposListCollaboratorsPermission.Admin => "admin",
                ReposListCollaboratorsPermission.Maintain => "maintain",
                ReposListCollaboratorsPermission.Pull => "pull",
                ReposListCollaboratorsPermission.Push => "push",
                ReposListCollaboratorsPermission.Triage => "triage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListCollaboratorsPermission? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ReposListCollaboratorsPermission.Admin,
                "maintain" => ReposListCollaboratorsPermission.Maintain,
                "pull" => ReposListCollaboratorsPermission.Pull,
                "push" => ReposListCollaboratorsPermission.Push,
                "triage" => ReposListCollaboratorsPermission.Triage,
                _ => null,
            };
        }
    }
}
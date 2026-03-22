//HintName: G.Models.ReposListCollaboratorsPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListCollaboratorsPermission
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
        [global::System.Runtime.Serialization.EnumMember(Value="pull")]
        Pull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
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
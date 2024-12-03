//HintName: G.Models.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsAddOrUpdateRepoPermissionsLegacyRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission value)
        {
            return value switch
            {
                TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Pull => "pull",
                TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Push => "push",
                TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "pull" => TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Pull,
                "push" => TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Push,
                "admin" => TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission.Admin,
                _ => null,
            };
        }
    }
}
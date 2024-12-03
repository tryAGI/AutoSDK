//HintName: G.Models.TeamsUpdateInOrgRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
    /// Default Value: pull
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsUpdateInOrgRequestPermission
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
    public static class TeamsUpdateInOrgRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateInOrgRequestPermission value)
        {
            return value switch
            {
                TeamsUpdateInOrgRequestPermission.Pull => "pull",
                TeamsUpdateInOrgRequestPermission.Push => "push",
                TeamsUpdateInOrgRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateInOrgRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "pull" => TeamsUpdateInOrgRequestPermission.Pull,
                "push" => TeamsUpdateInOrgRequestPermission.Push,
                "admin" => TeamsUpdateInOrgRequestPermission.Admin,
                _ => null,
            };
        }
    }
}
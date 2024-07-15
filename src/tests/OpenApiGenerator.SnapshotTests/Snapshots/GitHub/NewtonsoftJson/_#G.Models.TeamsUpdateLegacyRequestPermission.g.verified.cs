//HintName: G.Models.TeamsUpdateLegacyRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
    /// Default Value: pull
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsUpdateLegacyRequestPermission
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
    public static class TeamsUpdateLegacyRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateLegacyRequestPermission value)
        {
            return value switch
            {
                TeamsUpdateLegacyRequestPermission.Pull => "pull",
                TeamsUpdateLegacyRequestPermission.Push => "push",
                TeamsUpdateLegacyRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateLegacyRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "pull" => TeamsUpdateLegacyRequestPermission.Pull,
                "push" => TeamsUpdateLegacyRequestPermission.Push,
                "admin" => TeamsUpdateLegacyRequestPermission.Admin,
                _ => null,
            };
        }
    }
}
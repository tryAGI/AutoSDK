//HintName: G.Models.TeamsUpdateInOrgRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
    /// Default Value: pull
    /// </summary>
    public enum TeamsUpdateInOrgRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Pull,
        /// <summary>
        /// 
        /// </summary>
        Push,
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
                TeamsUpdateInOrgRequestPermission.Admin => "admin",
                TeamsUpdateInOrgRequestPermission.Pull => "pull",
                TeamsUpdateInOrgRequestPermission.Push => "push",
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
                "admin" => TeamsUpdateInOrgRequestPermission.Admin,
                "pull" => TeamsUpdateInOrgRequestPermission.Pull,
                "push" => TeamsUpdateInOrgRequestPermission.Push,
                _ => null,
            };
        }
    }
}
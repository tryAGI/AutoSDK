//HintName: G.Models.TeamsCreateRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
    /// Default Value: pull
    /// </summary>
    public enum TeamsCreateRequestPermission
    {
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
    public static class TeamsCreateRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsCreateRequestPermission value)
        {
            return value switch
            {
                TeamsCreateRequestPermission.Pull => "pull",
                TeamsCreateRequestPermission.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsCreateRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "pull" => TeamsCreateRequestPermission.Pull,
                "push" => TeamsCreateRequestPermission.Push,
                _ => null,
            };
        }
    }
}
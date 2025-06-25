//HintName: G.Models.DependentAvailableToolIdentifierAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependentAvailableToolIdentifierAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentAvailableToolIdentifierAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableToolIdentifierAccessLevel value)
        {
            return value switch
            {
                DependentAvailableToolIdentifierAccessLevel.Admin => "admin",
                DependentAvailableToolIdentifierAccessLevel.Editor => "editor",
                DependentAvailableToolIdentifierAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableToolIdentifierAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DependentAvailableToolIdentifierAccessLevel.Admin,
                "editor" => DependentAvailableToolIdentifierAccessLevel.Editor,
                "viewer" => DependentAvailableToolIdentifierAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}
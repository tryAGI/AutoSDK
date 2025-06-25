//HintName: G.Models.DependentAvailableAgentToolIdentifierAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependentAvailableAgentToolIdentifierAccessLevel
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
    public static class DependentAvailableAgentToolIdentifierAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableAgentToolIdentifierAccessLevel value)
        {
            return value switch
            {
                DependentAvailableAgentToolIdentifierAccessLevel.Admin => "admin",
                DependentAvailableAgentToolIdentifierAccessLevel.Editor => "editor",
                DependentAvailableAgentToolIdentifierAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableAgentToolIdentifierAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DependentAvailableAgentToolIdentifierAccessLevel.Admin,
                "editor" => DependentAvailableAgentToolIdentifierAccessLevel.Editor,
                "viewer" => DependentAvailableAgentToolIdentifierAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}
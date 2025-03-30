//HintName: G.Models.DependentAvailableAgentIdentifierAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependentAvailableAgentIdentifierAccessLevel
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
    public static class DependentAvailableAgentIdentifierAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableAgentIdentifierAccessLevel value)
        {
            return value switch
            {
                DependentAvailableAgentIdentifierAccessLevel.Admin => "admin",
                DependentAvailableAgentIdentifierAccessLevel.Editor => "editor",
                DependentAvailableAgentIdentifierAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableAgentIdentifierAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DependentAvailableAgentIdentifierAccessLevel.Admin,
                "editor" => DependentAvailableAgentIdentifierAccessLevel.Editor,
                "viewer" => DependentAvailableAgentIdentifierAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}
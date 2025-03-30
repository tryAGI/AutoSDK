//HintName: G.Models.DependentAvailableAgentToolIdentifierAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependentAvailableAgentToolIdentifierAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="editor")]
        Editor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="viewer")]
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
//HintName: G.Models.ResourceAccessInfoRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the user making the request
    /// </summary>
    public enum ResourceAccessInfoRole
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
    public static class ResourceAccessInfoRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAccessInfoRole value)
        {
            return value switch
            {
                ResourceAccessInfoRole.Admin => "admin",
                ResourceAccessInfoRole.Editor => "editor",
                ResourceAccessInfoRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAccessInfoRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResourceAccessInfoRole.Admin,
                "editor" => ResourceAccessInfoRole.Editor,
                "viewer" => ResourceAccessInfoRole.Viewer,
                _ => null,
            };
        }
    }
}
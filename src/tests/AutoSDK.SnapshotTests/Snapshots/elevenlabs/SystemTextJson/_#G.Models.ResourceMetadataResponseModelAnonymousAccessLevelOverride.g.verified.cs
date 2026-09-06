//HintName: G.Models.ResourceMetadataResponseModelAnonymousAccessLevelOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceMetadataResponseModelAnonymousAccessLevelOverride
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Commenter,
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
    public static class ResourceMetadataResponseModelAnonymousAccessLevelOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceMetadataResponseModelAnonymousAccessLevelOverride value)
        {
            return value switch
            {
                ResourceMetadataResponseModelAnonymousAccessLevelOverride.Admin => "admin",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride.Commenter => "commenter",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride.Editor => "editor",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceMetadataResponseModelAnonymousAccessLevelOverride? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResourceMetadataResponseModelAnonymousAccessLevelOverride.Admin,
                "commenter" => ResourceMetadataResponseModelAnonymousAccessLevelOverride.Commenter,
                "editor" => ResourceMetadataResponseModelAnonymousAccessLevelOverride.Editor,
                "viewer" => ResourceMetadataResponseModelAnonymousAccessLevelOverride.Viewer,
                _ => null,
            };
        }
    }
}
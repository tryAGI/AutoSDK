//HintName: G.Models.ResourceMetadataResponseModelAnonymousAccessLevelOverride2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceMetadataResponseModelAnonymousAccessLevelOverride2
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
        Commenter,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceMetadataResponseModelAnonymousAccessLevelOverride2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceMetadataResponseModelAnonymousAccessLevelOverride2 value)
        {
            return value switch
            {
                ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Admin => "admin",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Editor => "editor",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Commenter => "commenter",
                ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceMetadataResponseModelAnonymousAccessLevelOverride2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Admin,
                "editor" => ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Editor,
                "commenter" => ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Commenter,
                "viewer" => ResourceMetadataResponseModelAnonymousAccessLevelOverride2.Viewer,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ResourceMetadataResponseModelAnonymousAccessLevelOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResourceMetadataResponseModelAnonymousAccessLevelOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commenter")]
        Commenter,
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
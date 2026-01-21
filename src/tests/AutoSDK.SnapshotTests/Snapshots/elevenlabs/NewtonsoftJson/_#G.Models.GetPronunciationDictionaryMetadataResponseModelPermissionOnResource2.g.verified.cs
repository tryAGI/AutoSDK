//HintName: G.Models.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2
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
    public static class GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2 value)
        {
            return value switch
            {
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Admin => "admin",
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Editor => "editor",
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Admin,
                "editor" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Editor,
                "viewer" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2.Viewer,
                _ => null,
            };
        }
    }
}
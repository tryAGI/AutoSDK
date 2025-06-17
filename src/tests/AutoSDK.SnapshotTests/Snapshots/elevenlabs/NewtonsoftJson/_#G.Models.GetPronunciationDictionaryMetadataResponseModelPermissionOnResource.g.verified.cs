//HintName: G.Models.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission on the resource of the pronunciation dictionary.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPronunciationDictionaryMetadataResponseModelPermissionOnResource
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
    public static class GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionaryMetadataResponseModelPermissionOnResource value)
        {
            return value switch
            {
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Admin => "admin",
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Editor => "editor",
                GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Admin,
                "editor" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Editor,
                "viewer" => GetPronunciationDictionaryMetadataResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
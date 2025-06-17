//HintName: G.Models.AddPronunciationDictionaryResponseModelPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission on the resource of the pronunciation dictionary.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddPronunciationDictionaryResponseModelPermissionOnResource
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
    public static class AddPronunciationDictionaryResponseModelPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddPronunciationDictionaryResponseModelPermissionOnResource value)
        {
            return value switch
            {
                AddPronunciationDictionaryResponseModelPermissionOnResource.Admin => "admin",
                AddPronunciationDictionaryResponseModelPermissionOnResource.Editor => "editor",
                AddPronunciationDictionaryResponseModelPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddPronunciationDictionaryResponseModelPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AddPronunciationDictionaryResponseModelPermissionOnResource.Admin,
                "editor" => AddPronunciationDictionaryResponseModelPermissionOnResource.Editor,
                "viewer" => AddPronunciationDictionaryResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
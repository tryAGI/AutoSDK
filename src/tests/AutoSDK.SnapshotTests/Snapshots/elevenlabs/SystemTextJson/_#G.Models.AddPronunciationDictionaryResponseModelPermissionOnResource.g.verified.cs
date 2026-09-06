//HintName: G.Models.AddPronunciationDictionaryResponseModelPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddPronunciationDictionaryResponseModelPermissionOnResource
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
                AddPronunciationDictionaryResponseModelPermissionOnResource.Commenter => "commenter",
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
                "commenter" => AddPronunciationDictionaryResponseModelPermissionOnResource.Commenter,
                "editor" => AddPronunciationDictionaryResponseModelPermissionOnResource.Editor,
                "viewer" => AddPronunciationDictionaryResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
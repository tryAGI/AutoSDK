//HintName: G.Models.AddPronunciationDictionaryResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddPronunciationDictionaryResponseModelPermissionOnResource2
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
    public static class AddPronunciationDictionaryResponseModelPermissionOnResource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddPronunciationDictionaryResponseModelPermissionOnResource2 value)
        {
            return value switch
            {
                AddPronunciationDictionaryResponseModelPermissionOnResource2.Admin => "admin",
                AddPronunciationDictionaryResponseModelPermissionOnResource2.Editor => "editor",
                AddPronunciationDictionaryResponseModelPermissionOnResource2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddPronunciationDictionaryResponseModelPermissionOnResource2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AddPronunciationDictionaryResponseModelPermissionOnResource2.Admin,
                "editor" => AddPronunciationDictionaryResponseModelPermissionOnResource2.Editor,
                "viewer" => AddPronunciationDictionaryResponseModelPermissionOnResource2.Viewer,
                _ => null,
            };
        }
    }
}
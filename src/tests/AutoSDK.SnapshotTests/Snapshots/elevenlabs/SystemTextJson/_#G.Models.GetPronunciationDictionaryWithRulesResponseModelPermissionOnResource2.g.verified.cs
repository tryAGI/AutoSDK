//HintName: G.Models.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2
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
    public static class GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2 value)
        {
            return value switch
            {
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Admin => "admin",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Commenter => "commenter",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Editor => "editor",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Admin,
                "commenter" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Commenter,
                "editor" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Editor,
                "viewer" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2.Viewer,
                _ => null,
            };
        }
    }
}
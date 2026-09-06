//HintName: G.Models.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource
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
    public static class GetPronunciationDictionaryWithRulesResponseModelPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource value)
        {
            return value switch
            {
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Admin => "admin",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Commenter => "commenter",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Editor => "editor",
                GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Admin,
                "commenter" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Commenter,
                "editor" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Editor,
                "viewer" => GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
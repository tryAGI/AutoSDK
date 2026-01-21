//HintName: G.Models.AddPronunciationDictionaryResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddPronunciationDictionaryResponseModelPermissionOnResource2
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
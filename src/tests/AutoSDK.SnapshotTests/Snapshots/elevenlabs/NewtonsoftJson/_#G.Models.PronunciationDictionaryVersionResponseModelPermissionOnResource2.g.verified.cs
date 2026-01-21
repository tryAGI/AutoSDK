//HintName: G.Models.PronunciationDictionaryVersionResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PronunciationDictionaryVersionResponseModelPermissionOnResource2
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
    public static class PronunciationDictionaryVersionResponseModelPermissionOnResource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryVersionResponseModelPermissionOnResource2 value)
        {
            return value switch
            {
                PronunciationDictionaryVersionResponseModelPermissionOnResource2.Admin => "admin",
                PronunciationDictionaryVersionResponseModelPermissionOnResource2.Editor => "editor",
                PronunciationDictionaryVersionResponseModelPermissionOnResource2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryVersionResponseModelPermissionOnResource2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PronunciationDictionaryVersionResponseModelPermissionOnResource2.Admin,
                "editor" => PronunciationDictionaryVersionResponseModelPermissionOnResource2.Editor,
                "viewer" => PronunciationDictionaryVersionResponseModelPermissionOnResource2.Viewer,
                _ => null,
            };
        }
    }
}
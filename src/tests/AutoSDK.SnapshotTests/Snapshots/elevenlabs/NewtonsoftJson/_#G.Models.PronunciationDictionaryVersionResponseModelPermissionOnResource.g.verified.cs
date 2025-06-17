//HintName: G.Models.PronunciationDictionaryVersionResponseModelPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PronunciationDictionaryVersionResponseModelPermissionOnResource
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
    public static class PronunciationDictionaryVersionResponseModelPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryVersionResponseModelPermissionOnResource value)
        {
            return value switch
            {
                PronunciationDictionaryVersionResponseModelPermissionOnResource.Admin => "admin",
                PronunciationDictionaryVersionResponseModelPermissionOnResource.Editor => "editor",
                PronunciationDictionaryVersionResponseModelPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryVersionResponseModelPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PronunciationDictionaryVersionResponseModelPermissionOnResource.Admin,
                "editor" => PronunciationDictionaryVersionResponseModelPermissionOnResource.Editor,
                "viewer" => PronunciationDictionaryVersionResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
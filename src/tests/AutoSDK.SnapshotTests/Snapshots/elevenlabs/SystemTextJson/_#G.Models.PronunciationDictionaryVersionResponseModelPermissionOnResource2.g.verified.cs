//HintName: G.Models.PronunciationDictionaryVersionResponseModelPermissionOnResource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PronunciationDictionaryVersionResponseModelPermissionOnResource2
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
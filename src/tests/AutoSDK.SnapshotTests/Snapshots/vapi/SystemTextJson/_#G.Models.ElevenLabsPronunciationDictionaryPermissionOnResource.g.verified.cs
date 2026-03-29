//HintName: G.Models.ElevenLabsPronunciationDictionaryPermissionOnResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission level on this resource
    /// </summary>
    public enum ElevenLabsPronunciationDictionaryPermissionOnResource
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
    public static class ElevenLabsPronunciationDictionaryPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsPronunciationDictionaryPermissionOnResource value)
        {
            return value switch
            {
                ElevenLabsPronunciationDictionaryPermissionOnResource.Admin => "admin",
                ElevenLabsPronunciationDictionaryPermissionOnResource.Editor => "editor",
                ElevenLabsPronunciationDictionaryPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsPronunciationDictionaryPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ElevenLabsPronunciationDictionaryPermissionOnResource.Admin,
                "editor" => ElevenLabsPronunciationDictionaryPermissionOnResource.Editor,
                "viewer" => ElevenLabsPronunciationDictionaryPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}
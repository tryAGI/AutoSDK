//HintName: G.Models.CreateClipStreamRequestScriptVariant2Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateClipStreamRequestScriptVariant2Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestScriptVariant2Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant2Type2 value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant2Type2.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant2Type2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateClipStreamRequestScriptVariant2Type2.Audio,
                _ => null,
            };
        }
    }
}
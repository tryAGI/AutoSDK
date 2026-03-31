//HintName: G.Models.CreateClipStreamRequestScriptVariant1Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateClipStreamRequestScriptVariant1Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestScriptVariant1Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1Type2 value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1Type2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1Type2? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateClipStreamRequestScriptVariant1Type2.Text,
                _ => null,
            };
        }
    }
}
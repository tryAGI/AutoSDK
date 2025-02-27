//HintName: G.Models.TextEditor20250124Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditor20250124Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_20250124")]
        TextEditor20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditor20250124TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditor20250124Type value)
        {
            return value switch
            {
                TextEditor20250124Type.TextEditor20250124 => "text_editor_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditor20250124Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250124" => TextEditor20250124Type.TextEditor20250124,
                _ => null,
            };
        }
    }
}
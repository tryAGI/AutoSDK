//HintName: G.Models.MessagesRequestToolsItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf2Type.TextEditor20250124 => "text_editor_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20250124" => MessagesRequestToolsItemsOneOf2Type.TextEditor20250124,
                _ => null,
            };
        }
    }
}
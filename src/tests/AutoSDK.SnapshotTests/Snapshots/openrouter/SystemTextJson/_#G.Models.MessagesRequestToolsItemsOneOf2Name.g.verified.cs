//HintName: G.Models.MessagesRequestToolsItemsOneOf2Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf2Name
    {
        /// <summary>
        /// 
        /// </summary>
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf2NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf2Name value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf2Name.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf2Name? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => MessagesRequestToolsItemsOneOf2Name.StrReplaceEditor,
                _ => null,
            };
        }
    }
}
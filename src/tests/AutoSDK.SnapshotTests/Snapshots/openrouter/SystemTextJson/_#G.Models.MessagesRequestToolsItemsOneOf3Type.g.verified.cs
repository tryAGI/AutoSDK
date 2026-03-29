//HintName: G.Models.MessagesRequestToolsItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch20250305,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf3Type value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf3Type.WebSearch20250305 => "web_search_20250305",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_20250305" => MessagesRequestToolsItemsOneOf3Type.WebSearch20250305,
                _ => null,
            };
        }
    }
}
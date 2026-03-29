//HintName: G.Models.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}
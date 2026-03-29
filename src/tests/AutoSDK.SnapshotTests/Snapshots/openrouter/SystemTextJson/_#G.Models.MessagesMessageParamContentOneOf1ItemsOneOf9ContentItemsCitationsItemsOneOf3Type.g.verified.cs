//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}
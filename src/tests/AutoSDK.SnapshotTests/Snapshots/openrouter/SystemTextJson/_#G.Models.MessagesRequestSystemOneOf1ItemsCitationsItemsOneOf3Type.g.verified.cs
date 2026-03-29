//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4Type.SearchResultLocation,
                _ => null,
            };
        }
    }
}
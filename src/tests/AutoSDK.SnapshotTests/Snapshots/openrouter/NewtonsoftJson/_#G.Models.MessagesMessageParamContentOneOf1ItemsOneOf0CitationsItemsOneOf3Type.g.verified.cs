//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_result_location")]
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result_location" => MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_result_location")]
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type.SearchResultLocation,
                _ => null,
            };
        }
    }
}
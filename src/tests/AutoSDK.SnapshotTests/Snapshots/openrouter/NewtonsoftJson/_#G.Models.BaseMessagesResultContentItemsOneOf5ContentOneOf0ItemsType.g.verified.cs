//HintName: G.Models.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_result")]
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType.WebSearchResult,
                _ => null,
            };
        }
    }
}
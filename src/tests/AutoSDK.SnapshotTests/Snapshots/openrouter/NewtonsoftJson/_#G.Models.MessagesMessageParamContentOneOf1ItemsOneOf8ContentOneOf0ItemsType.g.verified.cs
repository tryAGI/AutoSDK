//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType
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
    public static class MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsType.WebSearchResult,
                _ => null,
            };
        }
    }
}
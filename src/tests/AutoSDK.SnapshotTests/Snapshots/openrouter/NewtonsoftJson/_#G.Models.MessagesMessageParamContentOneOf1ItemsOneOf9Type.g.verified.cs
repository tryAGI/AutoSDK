//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_result")]
        SearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9Type.SearchResult => "search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9Type? ToEnum(string value)
        {
            return value switch
            {
                "search_result" => MessagesMessageParamContentOneOf1ItemsOneOf9Type.SearchResult,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.MessagesRequestToolsItemsOneOf4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestToolsItemsOneOf4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_20260209")]
        WebSearch20260209,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf4Type value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf4Type.WebSearch20260209 => "web_search_20260209",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf4Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_20260209" => MessagesRequestToolsItemsOneOf4Type.WebSearch20260209,
                _ => null,
            };
        }
    }
}
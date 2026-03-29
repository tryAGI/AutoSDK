//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_fetch_result")]
        WebFetchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1Type.WebFetchResult => "web_fetch_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => BaseMessagesResultContentItemsOneOf6ContentOneOf1Type.WebFetchResult,
                _ => null,
            };
        }
    }
}
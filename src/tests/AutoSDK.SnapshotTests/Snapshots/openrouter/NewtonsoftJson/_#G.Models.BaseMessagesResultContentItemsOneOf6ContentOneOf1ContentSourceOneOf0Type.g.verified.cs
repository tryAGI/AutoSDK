//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type.Base64,
                _ => null,
            };
        }
    }
}
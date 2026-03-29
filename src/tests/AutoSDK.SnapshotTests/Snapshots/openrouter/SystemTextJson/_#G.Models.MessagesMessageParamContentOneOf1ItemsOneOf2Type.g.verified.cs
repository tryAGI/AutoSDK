//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2Type.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "document" => MessagesMessageParamContentOneOf1ItemsOneOf2Type.Document,
                _ => null,
            };
        }
    }
}
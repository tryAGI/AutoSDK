//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "url" => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3Type.Url,
                _ => null,
            };
        }
    }
}
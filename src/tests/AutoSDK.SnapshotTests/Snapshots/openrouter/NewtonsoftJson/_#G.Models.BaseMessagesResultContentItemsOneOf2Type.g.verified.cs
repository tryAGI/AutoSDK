//HintName: G.Models.BaseMessagesResultContentItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf2Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf2Type.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => BaseMessagesResultContentItemsOneOf2Type.Thinking,
                _ => null,
            };
        }
    }
}
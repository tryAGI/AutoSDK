//HintName: G.Models.OpenAIChatRequestMessageToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIChatRequestMessageToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatRequestMessageToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatRequestMessageToolCallType value)
        {
            return value switch
            {
                OpenAIChatRequestMessageToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatRequestMessageToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAIChatRequestMessageToolCallType.Function,
                _ => null,
            };
        }
    }
}
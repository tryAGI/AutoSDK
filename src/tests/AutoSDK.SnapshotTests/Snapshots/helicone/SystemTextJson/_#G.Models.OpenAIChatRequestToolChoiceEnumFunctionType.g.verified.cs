//HintName: G.Models.OpenAIChatRequestToolChoiceEnumFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIChatRequestToolChoiceEnumFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatRequestToolChoiceEnumFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatRequestToolChoiceEnumFunctionType value)
        {
            return value switch
            {
                OpenAIChatRequestToolChoiceEnumFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatRequestToolChoiceEnumFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAIChatRequestToolChoiceEnumFunctionType.Function,
                _ => null,
            };
        }
    }
}
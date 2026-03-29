//HintName: G.Models.OpenAIChatRequestToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIChatRequestToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatRequestToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatRequestToolType value)
        {
            return value switch
            {
                OpenAIChatRequestToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatRequestToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAIChatRequestToolType.Function,
                _ => null,
            };
        }
    }
}
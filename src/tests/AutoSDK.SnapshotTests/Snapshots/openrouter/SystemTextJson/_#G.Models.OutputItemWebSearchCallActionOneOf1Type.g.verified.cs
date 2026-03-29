//HintName: G.Models.OutputItemWebSearchCallActionOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemWebSearchCallActionOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionOneOf1Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionOneOf1Type.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => OutputItemWebSearchCallActionOneOf1Type.OpenPage,
                _ => null,
            };
        }
    }
}
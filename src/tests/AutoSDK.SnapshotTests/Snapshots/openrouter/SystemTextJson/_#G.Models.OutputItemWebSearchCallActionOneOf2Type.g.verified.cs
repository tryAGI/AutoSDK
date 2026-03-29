//HintName: G.Models.OutputItemWebSearchCallActionOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemWebSearchCallActionOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        FindInPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionOneOf2Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionOneOf2Type.FindInPage => "find_in_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => OutputItemWebSearchCallActionOneOf2Type.FindInPage,
                _ => null,
            };
        }
    }
}
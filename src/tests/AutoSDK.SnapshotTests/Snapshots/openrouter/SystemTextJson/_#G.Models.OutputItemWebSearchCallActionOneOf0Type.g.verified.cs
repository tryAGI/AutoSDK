//HintName: G.Models.OutputItemWebSearchCallActionOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemWebSearchCallActionOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionOneOf0Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionOneOf0Type.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "search" => OutputItemWebSearchCallActionOneOf0Type.Search,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.LLMConfigCompatibilityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigCompatibilityType
    {
        /// <summary>
        /// 
        /// </summary>
        Gguf,
        /// <summary>
        /// 
        /// </summary>
        Mlx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCompatibilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCompatibilityType value)
        {
            return value switch
            {
                LLMConfigCompatibilityType.Gguf => "gguf",
                LLMConfigCompatibilityType.Mlx => "mlx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCompatibilityType? ToEnum(string value)
        {
            return value switch
            {
                "gguf" => LLMConfigCompatibilityType.Gguf,
                "mlx" => LLMConfigCompatibilityType.Mlx,
                _ => null,
            };
        }
    }
}
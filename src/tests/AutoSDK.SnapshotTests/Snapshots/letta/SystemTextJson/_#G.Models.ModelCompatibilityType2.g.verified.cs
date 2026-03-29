//HintName: G.Models.ModelCompatibilityType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelCompatibilityType2
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
    public static class ModelCompatibilityType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCompatibilityType2 value)
        {
            return value switch
            {
                ModelCompatibilityType2.Gguf => "gguf",
                ModelCompatibilityType2.Mlx => "mlx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCompatibilityType2? ToEnum(string value)
        {
            return value switch
            {
                "gguf" => ModelCompatibilityType2.Gguf,
                "mlx" => ModelCompatibilityType2.Mlx,
                _ => null,
            };
        }
    }
}
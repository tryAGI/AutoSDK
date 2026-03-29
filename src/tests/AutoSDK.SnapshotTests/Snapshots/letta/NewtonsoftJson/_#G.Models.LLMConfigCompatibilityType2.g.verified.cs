//HintName: G.Models.LLMConfigCompatibilityType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigCompatibilityType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gguf")]
        Gguf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mlx")]
        Mlx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCompatibilityType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCompatibilityType2 value)
        {
            return value switch
            {
                LLMConfigCompatibilityType2.Gguf => "gguf",
                LLMConfigCompatibilityType2.Mlx => "mlx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCompatibilityType2? ToEnum(string value)
        {
            return value switch
            {
                "gguf" => LLMConfigCompatibilityType2.Gguf,
                "mlx" => LLMConfigCompatibilityType2.Mlx,
                _ => null,
            };
        }
    }
}
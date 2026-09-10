//HintName: G.Models.ModelCompatibilityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelCompatibilityType
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
    public static class ModelCompatibilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCompatibilityType value)
        {
            return value switch
            {
                ModelCompatibilityType.Gguf => "gguf",
                ModelCompatibilityType.Mlx => "mlx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCompatibilityType? ToEnum(string value)
        {
            return value switch
            {
                "gguf" => ModelCompatibilityType.Gguf,
                "mlx" => ModelCompatibilityType.Mlx,
                _ => null,
            };
        }
    }
}
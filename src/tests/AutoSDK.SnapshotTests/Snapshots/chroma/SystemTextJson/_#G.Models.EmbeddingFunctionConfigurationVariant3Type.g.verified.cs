//HintName: G.Models.EmbeddingFunctionConfigurationVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingFunctionConfigurationVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingFunctionConfigurationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingFunctionConfigurationVariant3Type value)
        {
            return value switch
            {
                EmbeddingFunctionConfigurationVariant3Type.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingFunctionConfigurationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => EmbeddingFunctionConfigurationVariant3Type.Unknown,
                _ => null,
            };
        }
    }
}
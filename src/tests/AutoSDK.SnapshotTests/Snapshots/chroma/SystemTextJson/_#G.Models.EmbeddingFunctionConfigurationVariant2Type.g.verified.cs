//HintName: G.Models.EmbeddingFunctionConfigurationVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingFunctionConfigurationVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Known,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingFunctionConfigurationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingFunctionConfigurationVariant2Type value)
        {
            return value switch
            {
                EmbeddingFunctionConfigurationVariant2Type.Known => "known",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingFunctionConfigurationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "known" => EmbeddingFunctionConfigurationVariant2Type.Known,
                _ => null,
            };
        }
    }
}
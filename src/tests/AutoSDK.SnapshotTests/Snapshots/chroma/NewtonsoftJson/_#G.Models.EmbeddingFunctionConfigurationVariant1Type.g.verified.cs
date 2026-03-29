//HintName: G.Models.EmbeddingFunctionConfigurationVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingFunctionConfigurationVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingFunctionConfigurationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingFunctionConfigurationVariant1Type value)
        {
            return value switch
            {
                EmbeddingFunctionConfigurationVariant1Type.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingFunctionConfigurationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => EmbeddingFunctionConfigurationVariant1Type.Legacy,
                _ => null,
            };
        }
    }
}
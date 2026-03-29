//HintName: G.Models.EmbeddingMultiInputMetadataInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingMultiInputMetadataInputType
    {
        /// <summary>
        /// 
        /// </summary>
        MultiInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingMultiInputMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingMultiInputMetadataInputType value)
        {
            return value switch
            {
                EmbeddingMultiInputMetadataInputType.MultiInput => "multi_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingMultiInputMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "multi_input" => EmbeddingMultiInputMetadataInputType.MultiInput,
                _ => null,
            };
        }
    }
}
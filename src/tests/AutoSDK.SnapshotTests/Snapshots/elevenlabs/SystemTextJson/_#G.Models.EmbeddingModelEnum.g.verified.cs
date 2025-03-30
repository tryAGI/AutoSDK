//HintName: G.Models.EmbeddingModelEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        E5Mistral7bInstruct,
        /// <summary>
        /// 
        /// </summary>
        MultilingualE5LargeInstruct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingModelEnum value)
        {
            return value switch
            {
                EmbeddingModelEnum.E5Mistral7bInstruct => "e5_mistral_7b_instruct",
                EmbeddingModelEnum.MultilingualE5LargeInstruct => "multilingual_e5_large_instruct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "e5_mistral_7b_instruct" => EmbeddingModelEnum.E5Mistral7bInstruct,
                "multilingual_e5_large_instruct" => EmbeddingModelEnum.MultilingualE5LargeInstruct,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SparseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for sparse model types supported in LlamaCloud.<br/>
    /// SPLADE: Uses HuggingFace Splade model for sparse embeddings<br/>
    /// BM25: Uses Qdrant's FastEmbed BM25 model for sparse embeddings<br/>
    /// AUTO: Automatically selects based on deployment mode (BYOC uses term frequency, Cloud uses Splade)
    /// </summary>
    public enum SparseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Bm25,
        /// <summary>
        /// 
        /// </summary>
        Splade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseModelType value)
        {
            return value switch
            {
                SparseModelType.Auto => "auto",
                SparseModelType.Bm25 => "bm25",
                SparseModelType.Splade => "splade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseModelType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SparseModelType.Auto,
                "bm25" => SparseModelType.Bm25,
                "splade" => SparseModelType.Splade,
                _ => null,
            };
        }
    }
}
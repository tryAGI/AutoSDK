//HintName: G.Models.VertexEmbeddingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Copied from llama_index.embeddings.vertex.base.VertexEmbeddingMode<br/>
    /// since importing llama_index.embeddings.vertex.base incurs a lot of memory usage.
    /// </summary>
    public enum VertexEmbeddingMode
    {
        /// <summary>
        /// 
        /// </summary>
        Classification,
        /// <summary>
        /// 
        /// </summary>
        Clustering,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Retrieval,
        /// <summary>
        /// 
        /// </summary>
        Similarity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VertexEmbeddingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VertexEmbeddingMode value)
        {
            return value switch
            {
                VertexEmbeddingMode.Classification => "classification",
                VertexEmbeddingMode.Clustering => "clustering",
                VertexEmbeddingMode.Default => "default",
                VertexEmbeddingMode.Retrieval => "retrieval",
                VertexEmbeddingMode.Similarity => "similarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VertexEmbeddingMode? ToEnum(string value)
        {
            return value switch
            {
                "classification" => VertexEmbeddingMode.Classification,
                "clustering" => VertexEmbeddingMode.Clustering,
                "default" => VertexEmbeddingMode.Default,
                "retrieval" => VertexEmbeddingMode.Retrieval,
                "similarity" => VertexEmbeddingMode.Similarity,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SummarizeDocumentStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarizeDocumentStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        End,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeDocumentStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeDocumentStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                SummarizeDocumentStreamedResponseDiscriminatorType.Error => "error",
                SummarizeDocumentStreamedResponseDiscriminatorType.End => "end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeDocumentStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generation_chunk" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_info" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationInfo,
                "generation_end" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationEnd,
                "error" => SummarizeDocumentStreamedResponseDiscriminatorType.Error,
                "end" => SummarizeDocumentStreamedResponseDiscriminatorType.End,
                _ => null,
            };
        }
    }
}
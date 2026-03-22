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
        End,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        GenerationInfo,
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
                SummarizeDocumentStreamedResponseDiscriminatorType.End => "end",
                SummarizeDocumentStreamedResponseDiscriminatorType.Error => "error",
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                SummarizeDocumentStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
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
                "end" => SummarizeDocumentStreamedResponseDiscriminatorType.End,
                "error" => SummarizeDocumentStreamedResponseDiscriminatorType.Error,
                "generation_chunk" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_end" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationEnd,
                "generation_info" => SummarizeDocumentStreamedResponseDiscriminatorType.GenerationInfo,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RAGIndexStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RAGIndexStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        RagLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        DocumentTooSmall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RAGIndexStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RAGIndexStatus value)
        {
            return value switch
            {
                RAGIndexStatus.Created => "created",
                RAGIndexStatus.Processing => "processing",
                RAGIndexStatus.Failed => "failed",
                RAGIndexStatus.Succeeded => "succeeded",
                RAGIndexStatus.RagLimitExceeded => "rag_limit_exceeded",
                RAGIndexStatus.DocumentTooSmall => "document_too_small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RAGIndexStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => RAGIndexStatus.Created,
                "processing" => RAGIndexStatus.Processing,
                "failed" => RAGIndexStatus.Failed,
                "succeeded" => RAGIndexStatus.Succeeded,
                "rag_limit_exceeded" => RAGIndexStatus.RagLimitExceeded,
                "document_too_small" => RAGIndexStatus.DocumentTooSmall,
                _ => null,
            };
        }
    }
}
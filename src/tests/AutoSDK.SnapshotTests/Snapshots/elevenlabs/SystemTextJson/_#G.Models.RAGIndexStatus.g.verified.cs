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
        CannotIndexFolder,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        DocumentTooSmall,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        RagLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
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
                RAGIndexStatus.CannotIndexFolder => "cannot_index_folder",
                RAGIndexStatus.Created => "created",
                RAGIndexStatus.DocumentTooSmall => "document_too_small",
                RAGIndexStatus.Failed => "failed",
                RAGIndexStatus.New => "new",
                RAGIndexStatus.Processing => "processing",
                RAGIndexStatus.RagLimitExceeded => "rag_limit_exceeded",
                RAGIndexStatus.Succeeded => "succeeded",
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
                "cannot_index_folder" => RAGIndexStatus.CannotIndexFolder,
                "created" => RAGIndexStatus.Created,
                "document_too_small" => RAGIndexStatus.DocumentTooSmall,
                "failed" => RAGIndexStatus.Failed,
                "new" => RAGIndexStatus.New,
                "processing" => RAGIndexStatus.Processing,
                "rag_limit_exceeded" => RAGIndexStatus.RagLimitExceeded,
                "succeeded" => RAGIndexStatus.Succeeded,
                _ => null,
            };
        }
    }
}
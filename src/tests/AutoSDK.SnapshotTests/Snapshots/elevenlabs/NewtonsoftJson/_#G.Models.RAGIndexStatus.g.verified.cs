//HintName: G.Models.RAGIndexStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RAGIndexStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cannot_index_folder")]
        CannotIndexFolder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_too_small")]
        DocumentTooSmall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new")]
        New,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag_limit_exceeded")]
        RagLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
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
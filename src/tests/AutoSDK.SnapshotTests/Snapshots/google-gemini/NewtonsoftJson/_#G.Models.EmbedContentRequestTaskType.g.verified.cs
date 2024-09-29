//HintName: G.Models.EmbedContentRequestTaskType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Optional task type for which the embeddings will be used. Can only be set for `models/embedding-001` or newer models.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedContentRequestTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_TYPE_UNSPECIFIED")]
        TASKTYPEUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RETRIEVAL_QUERY")]
        RETRIEVALQUERY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RETRIEVAL_DOCUMENT")]
        RETRIEVALDOCUMENT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SEMANTIC_SIMILARITY")]
        SEMANTICSIMILARITY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLASSIFICATION")]
        CLASSIFICATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLUSTERING")]
        CLUSTERING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUESTION_ANSWERING")]
        QUESTIONANSWERING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FACT_VERIFICATION")]
        FACTVERIFICATION,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedContentRequestTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentRequestTaskType value)
        {
            return value switch
            {
                EmbedContentRequestTaskType.TASKTYPEUNSPECIFIED => "TASK_TYPE_UNSPECIFIED",
                EmbedContentRequestTaskType.RETRIEVALQUERY => "RETRIEVAL_QUERY",
                EmbedContentRequestTaskType.RETRIEVALDOCUMENT => "RETRIEVAL_DOCUMENT",
                EmbedContentRequestTaskType.SEMANTICSIMILARITY => "SEMANTIC_SIMILARITY",
                EmbedContentRequestTaskType.CLASSIFICATION => "CLASSIFICATION",
                EmbedContentRequestTaskType.CLUSTERING => "CLUSTERING",
                EmbedContentRequestTaskType.QUESTIONANSWERING => "QUESTION_ANSWERING",
                EmbedContentRequestTaskType.FACTVERIFICATION => "FACT_VERIFICATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentRequestTaskType? ToEnum(string value)
        {
            return value switch
            {
                "TASK_TYPE_UNSPECIFIED" => EmbedContentRequestTaskType.TASKTYPEUNSPECIFIED,
                "RETRIEVAL_QUERY" => EmbedContentRequestTaskType.RETRIEVALQUERY,
                "RETRIEVAL_DOCUMENT" => EmbedContentRequestTaskType.RETRIEVALDOCUMENT,
                "SEMANTIC_SIMILARITY" => EmbedContentRequestTaskType.SEMANTICSIMILARITY,
                "CLASSIFICATION" => EmbedContentRequestTaskType.CLASSIFICATION,
                "CLUSTERING" => EmbedContentRequestTaskType.CLUSTERING,
                "QUESTION_ANSWERING" => EmbedContentRequestTaskType.QUESTIONANSWERING,
                "FACT_VERIFICATION" => EmbedContentRequestTaskType.FACTVERIFICATION,
                _ => null,
            };
        }
    }
}
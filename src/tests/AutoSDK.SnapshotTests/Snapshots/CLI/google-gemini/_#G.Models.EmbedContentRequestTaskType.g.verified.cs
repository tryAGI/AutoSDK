//HintName: G.Models.EmbedContentRequestTaskType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Optional task type for which the embeddings will be used. Can only be set for `models/embedding-001` or newer models.
    /// </summary>
    public enum EmbedContentRequestTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        TASKTYPEUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        RETRIEVALQUERY,
        /// <summary>
        /// 
        /// </summary>
        RETRIEVALDOCUMENT,
        /// <summary>
        /// 
        /// </summary>
        SEMANTICSIMILARITY,
        /// <summary>
        /// 
        /// </summary>
        CLASSIFICATION,
        /// <summary>
        /// 
        /// </summary>
        CLUSTERING,
        /// <summary>
        /// 
        /// </summary>
        QUESTIONANSWERING,
        /// <summary>
        /// 
        /// </summary>
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
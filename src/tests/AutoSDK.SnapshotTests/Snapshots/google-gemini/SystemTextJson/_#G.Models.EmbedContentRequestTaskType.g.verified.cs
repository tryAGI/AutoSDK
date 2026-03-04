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
        TaskTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// 
        /// </summary>
        RetrievalDocument,
        /// <summary>
        /// 
        /// </summary>
        SemanticSimilarity,
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
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        FactVerification,
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
                EmbedContentRequestTaskType.TaskTypeUnspecified => "TASK_TYPE_UNSPECIFIED",
                EmbedContentRequestTaskType.RetrievalQuery => "RETRIEVAL_QUERY",
                EmbedContentRequestTaskType.RetrievalDocument => "RETRIEVAL_DOCUMENT",
                EmbedContentRequestTaskType.SemanticSimilarity => "SEMANTIC_SIMILARITY",
                EmbedContentRequestTaskType.Classification => "CLASSIFICATION",
                EmbedContentRequestTaskType.Clustering => "CLUSTERING",
                EmbedContentRequestTaskType.QuestionAnswering => "QUESTION_ANSWERING",
                EmbedContentRequestTaskType.FactVerification => "FACT_VERIFICATION",
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
                "TASK_TYPE_UNSPECIFIED" => EmbedContentRequestTaskType.TaskTypeUnspecified,
                "RETRIEVAL_QUERY" => EmbedContentRequestTaskType.RetrievalQuery,
                "RETRIEVAL_DOCUMENT" => EmbedContentRequestTaskType.RetrievalDocument,
                "SEMANTIC_SIMILARITY" => EmbedContentRequestTaskType.SemanticSimilarity,
                "CLASSIFICATION" => EmbedContentRequestTaskType.Classification,
                "CLUSTERING" => EmbedContentRequestTaskType.Clustering,
                "QUESTION_ANSWERING" => EmbedContentRequestTaskType.QuestionAnswering,
                "FACT_VERIFICATION" => EmbedContentRequestTaskType.FactVerification,
                _ => null,
            };
        }
    }
}
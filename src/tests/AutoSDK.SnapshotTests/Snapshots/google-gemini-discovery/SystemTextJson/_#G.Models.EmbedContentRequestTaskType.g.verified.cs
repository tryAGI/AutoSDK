//HintName: G.Models.EmbedContentRequestTaskType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Optional task type for which the embeddings will be used. Not supported on earlier models (`models/embedding-001`).
    /// </summary>
    public enum EmbedContentRequestTaskType
    {
        /// <summary>
        /// Specifies that the given text will be classified.
        /// </summary>
        Classification,
        /// <summary>
        /// Specifies that the embeddings will be used for clustering.
        /// </summary>
        Clustering,
        /// <summary>
        /// Specifies that the given text will be used for code retrieval.
        /// </summary>
        CodeRetrievalQuery,
        /// <summary>
        /// Specifies that the given text will be used for fact verification.
        /// </summary>
        FactVerification,
        /// <summary>
        /// Specifies that the given text will be used for question answering.
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// Specifies the given text is a document from the corpus being searched.
        /// </summary>
        RetrievalDocument,
        /// <summary>
        /// Specifies the given text is a query in a search/retrieval setting.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// Specifies the given text will be used for STS.
        /// </summary>
        SemanticSimilarity,
        /// <summary>
        /// Unset value, which will default to one of the other enum values.
        /// </summary>
        TaskTypeUnspecified,
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
                EmbedContentRequestTaskType.Classification => "CLASSIFICATION",
                EmbedContentRequestTaskType.Clustering => "CLUSTERING",
                EmbedContentRequestTaskType.CodeRetrievalQuery => "CODE_RETRIEVAL_QUERY",
                EmbedContentRequestTaskType.FactVerification => "FACT_VERIFICATION",
                EmbedContentRequestTaskType.QuestionAnswering => "QUESTION_ANSWERING",
                EmbedContentRequestTaskType.RetrievalDocument => "RETRIEVAL_DOCUMENT",
                EmbedContentRequestTaskType.RetrievalQuery => "RETRIEVAL_QUERY",
                EmbedContentRequestTaskType.SemanticSimilarity => "SEMANTIC_SIMILARITY",
                EmbedContentRequestTaskType.TaskTypeUnspecified => "TASK_TYPE_UNSPECIFIED",
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
                "CLASSIFICATION" => EmbedContentRequestTaskType.Classification,
                "CLUSTERING" => EmbedContentRequestTaskType.Clustering,
                "CODE_RETRIEVAL_QUERY" => EmbedContentRequestTaskType.CodeRetrievalQuery,
                "FACT_VERIFICATION" => EmbedContentRequestTaskType.FactVerification,
                "QUESTION_ANSWERING" => EmbedContentRequestTaskType.QuestionAnswering,
                "RETRIEVAL_DOCUMENT" => EmbedContentRequestTaskType.RetrievalDocument,
                "RETRIEVAL_QUERY" => EmbedContentRequestTaskType.RetrievalQuery,
                "SEMANTIC_SIMILARITY" => EmbedContentRequestTaskType.SemanticSimilarity,
                "TASK_TYPE_UNSPECIFIED" => EmbedContentRequestTaskType.TaskTypeUnspecified,
                _ => null,
            };
        }
    }
}
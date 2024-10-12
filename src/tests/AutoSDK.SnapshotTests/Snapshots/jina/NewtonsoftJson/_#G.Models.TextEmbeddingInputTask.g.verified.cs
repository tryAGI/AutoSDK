//HintName: G.Models.TextEmbeddingInputTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
    /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
    /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
    /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
    /// - "classification": Specifies that the embedding is used for classification.<br/>
    /// - "separation": Specifies that the embedding is used for clustering.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEmbeddingInputTask
    {
        /// <summary>
        /// Specifies the given text is a query in a search or retrieval setting.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieval.query")]
        RetrievalQuery,
        /// <summary>
        /// Specifies the given text is a document in a search or retrieval setting.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieval.passage")]
        RetrievalPassage,
        /// <summary>
        /// Specifies the given text is used for Semantic Textual Similarity.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-matching")]
        TextMatching,
        /// <summary>
        /// Specifies that the embedding is used for classification.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classification")]
        Classification,
        /// <summary>
        /// Specifies that the embedding is used for clustering.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="separation")]
        Separation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingInputTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingInputTask value)
        {
            return value switch
            {
                TextEmbeddingInputTask.RetrievalQuery => "retrieval.query",
                TextEmbeddingInputTask.RetrievalPassage => "retrieval.passage",
                TextEmbeddingInputTask.TextMatching => "text-matching",
                TextEmbeddingInputTask.Classification => "classification",
                TextEmbeddingInputTask.Separation => "separation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingInputTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => TextEmbeddingInputTask.RetrievalQuery,
                "retrieval.passage" => TextEmbeddingInputTask.RetrievalPassage,
                "text-matching" => TextEmbeddingInputTask.TextMatching,
                "classification" => TextEmbeddingInputTask.Classification,
                "separation" => TextEmbeddingInputTask.Separation,
                _ => null,
            };
        }
    }
}
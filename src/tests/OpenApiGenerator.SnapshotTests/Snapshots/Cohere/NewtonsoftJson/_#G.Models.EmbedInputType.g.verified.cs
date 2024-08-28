//HintName: G.Models.EmbedInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
    /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
    /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
    /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
    /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_document")]
        SearchDocument,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_query")]
        SearchQuery,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classification")]
        Classification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clustering")]
        Clustering,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedInputType value)
        {
            return value switch
            {
                EmbedInputType.SearchDocument => "search_document",
                EmbedInputType.SearchQuery => "search_query",
                EmbedInputType.Classification => "classification",
                EmbedInputType.Clustering => "clustering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedInputType? ToEnum(string value)
        {
            return value switch
            {
                "search_document" => EmbedInputType.SearchDocument,
                "search_query" => EmbedInputType.SearchQuery,
                "classification" => EmbedInputType.Classification,
                "clustering" => EmbedInputType.Clustering,
                _ => null,
            };
        }
    }
}
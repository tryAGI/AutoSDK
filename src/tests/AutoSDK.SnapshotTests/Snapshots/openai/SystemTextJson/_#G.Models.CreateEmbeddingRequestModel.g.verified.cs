//HintName: G.Models.CreateEmbeddingRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEmbeddingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Large,
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Small,
        /// <summary>
        /// 
        /// </summary>
        TextEmbeddingAda002,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingRequestModel value)
        {
            return value switch
            {
                CreateEmbeddingRequestModel.TextEmbedding3Large => "text-embedding-3-large",
                CreateEmbeddingRequestModel.TextEmbedding3Small => "text-embedding-3-small",
                CreateEmbeddingRequestModel.TextEmbeddingAda002 => "text-embedding-ada-002",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-3-large" => CreateEmbeddingRequestModel.TextEmbedding3Large,
                "text-embedding-3-small" => CreateEmbeddingRequestModel.TextEmbedding3Small,
                "text-embedding-ada-002" => CreateEmbeddingRequestModel.TextEmbeddingAda002,
                _ => null,
            };
        }
    }
}
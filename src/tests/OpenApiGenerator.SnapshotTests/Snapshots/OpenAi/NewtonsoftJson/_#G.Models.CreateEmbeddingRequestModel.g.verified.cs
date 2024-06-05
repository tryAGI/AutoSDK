//HintName: G.Models.CreateEmbeddingRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEmbeddingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-embedding-ada-002")]
        TextEmbeddingAda002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-embedding-3-small")]
        TextEmbedding3Small,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-embedding-3-large")]
        TextEmbedding3Large,
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
                CreateEmbeddingRequestModel.TextEmbeddingAda002 => "text-embedding-ada-002",
                CreateEmbeddingRequestModel.TextEmbedding3Small => "text-embedding-3-small",
                CreateEmbeddingRequestModel.TextEmbedding3Large => "text-embedding-3-large",
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
                "text-embedding-ada-002" => CreateEmbeddingRequestModel.TextEmbeddingAda002,
                "text-embedding-3-small" => CreateEmbeddingRequestModel.TextEmbedding3Small,
                "text-embedding-3-large" => CreateEmbeddingRequestModel.TextEmbedding3Large,
                _ => null,
            };
        }
    }
}
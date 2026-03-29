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
        NomicEmbedTextV15,
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
                CreateEmbeddingRequestModel.NomicEmbedTextV15 => "nomic-embed-text-v1_5",
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
                "nomic-embed-text-v1_5" => CreateEmbeddingRequestModel.NomicEmbedTextV15,
                _ => null,
            };
        }
    }
}
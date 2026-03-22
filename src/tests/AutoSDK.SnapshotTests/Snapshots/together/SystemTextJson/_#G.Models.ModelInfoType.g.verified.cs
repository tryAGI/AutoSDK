//HintName: G.Models.ModelInfoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: chat
    /// </summary>
    public enum ModelInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInfoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoType value)
        {
            return value switch
            {
                ModelInfoType.Chat => "chat",
                ModelInfoType.Code => "code",
                ModelInfoType.Embedding => "embedding",
                ModelInfoType.Image => "image",
                ModelInfoType.Language => "language",
                ModelInfoType.Moderation => "moderation",
                ModelInfoType.Rerank => "rerank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ModelInfoType.Chat,
                "code" => ModelInfoType.Code,
                "embedding" => ModelInfoType.Embedding,
                "image" => ModelInfoType.Image,
                "language" => ModelInfoType.Language,
                "moderation" => ModelInfoType.Moderation,
                "rerank" => ModelInfoType.Rerank,
                _ => null,
            };
        }
    }
}
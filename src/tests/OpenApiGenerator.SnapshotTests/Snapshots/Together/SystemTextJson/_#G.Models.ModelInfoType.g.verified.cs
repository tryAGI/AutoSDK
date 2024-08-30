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
        Language,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
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
                ModelInfoType.Language => "language",
                ModelInfoType.Code => "code",
                ModelInfoType.Image => "image",
                ModelInfoType.Embedding => "embedding",
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
                "language" => ModelInfoType.Language,
                "code" => ModelInfoType.Code,
                "image" => ModelInfoType.Image,
                "embedding" => ModelInfoType.Embedding,
                "moderation" => ModelInfoType.Moderation,
                "rerank" => ModelInfoType.Rerank,
                _ => null,
            };
        }
    }
}
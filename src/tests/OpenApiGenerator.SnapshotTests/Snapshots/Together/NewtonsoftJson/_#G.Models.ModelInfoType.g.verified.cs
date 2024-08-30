//HintName: G.Models.ModelInfoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: chat
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language")]
        Language,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderation")]
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
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
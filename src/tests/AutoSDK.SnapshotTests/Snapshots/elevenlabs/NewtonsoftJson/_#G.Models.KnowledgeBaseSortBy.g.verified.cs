//HintName: G.Models.KnowledgeBaseSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="size")]
        Size,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseSortBy value)
        {
            return value switch
            {
                KnowledgeBaseSortBy.CreatedAt => "created_at",
                KnowledgeBaseSortBy.Name => "name",
                KnowledgeBaseSortBy.Size => "size",
                KnowledgeBaseSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => KnowledgeBaseSortBy.CreatedAt,
                "name" => KnowledgeBaseSortBy.Name,
                "size" => KnowledgeBaseSortBy.Size,
                "updated_at" => KnowledgeBaseSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}
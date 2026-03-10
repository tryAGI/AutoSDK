//HintName: G.Models.KnowledgeBaseSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
        /// <summary>
        /// 
        /// </summary>
        Size,
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
                KnowledgeBaseSortBy.Name => "name",
                KnowledgeBaseSortBy.CreatedAt => "created_at",
                KnowledgeBaseSortBy.UpdatedAt => "updated_at",
                KnowledgeBaseSortBy.Size => "size",
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
                "name" => KnowledgeBaseSortBy.Name,
                "created_at" => KnowledgeBaseSortBy.CreatedAt,
                "updated_at" => KnowledgeBaseSortBy.UpdatedAt,
                "size" => KnowledgeBaseSortBy.Size,
                _ => null,
            };
        }
    }
}
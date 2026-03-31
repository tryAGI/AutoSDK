//HintName: G.Models.SortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Chats,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        CreatedBy,
        /// <summary>
        /// 
        /// </summary>
        ModifiedAt,
        /// <summary>
        /// 
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortBy value)
        {
            return value switch
            {
                SortBy.Chats => "chats",
                SortBy.CreatedAt => "created_at",
                SortBy.CreatedBy => "created_by",
                SortBy.ModifiedAt => "modified_at",
                SortBy.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortBy? ToEnum(string value)
        {
            return value switch
            {
                "chats" => SortBy.Chats,
                "created_at" => SortBy.CreatedAt,
                "created_by" => SortBy.CreatedBy,
                "modified_at" => SortBy.ModifiedAt,
                "score" => SortBy.Score,
                _ => null,
            };
        }
    }
}
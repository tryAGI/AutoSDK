//HintName: G.Models.ListMyAgentsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMyAgentsSortBy
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
    public static class ListMyAgentsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsSortBy value)
        {
            return value switch
            {
                ListMyAgentsSortBy.Chats => "chats",
                ListMyAgentsSortBy.CreatedAt => "created_at",
                ListMyAgentsSortBy.CreatedBy => "created_by",
                ListMyAgentsSortBy.ModifiedAt => "modified_at",
                ListMyAgentsSortBy.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "chats" => ListMyAgentsSortBy.Chats,
                "created_at" => ListMyAgentsSortBy.CreatedAt,
                "created_by" => ListMyAgentsSortBy.CreatedBy,
                "modified_at" => ListMyAgentsSortBy.ModifiedAt,
                "score" => ListMyAgentsSortBy.Score,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListMyAgentsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chats")]
        Chats,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_by")]
        CreatedBy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modified_at")]
        ModifiedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score")]
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
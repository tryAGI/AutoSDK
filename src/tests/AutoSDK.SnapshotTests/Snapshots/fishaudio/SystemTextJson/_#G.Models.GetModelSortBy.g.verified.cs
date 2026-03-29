//HintName: G.Models.GetModelSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: score
    /// </summary>
    public enum GetModelSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Score,
        /// <summary>
        /// 
        /// </summary>
        TaskCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelSortBy value)
        {
            return value switch
            {
                GetModelSortBy.CreatedAt => "created_at",
                GetModelSortBy.Score => "score",
                GetModelSortBy.TaskCount => "task_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetModelSortBy.CreatedAt,
                "score" => GetModelSortBy.Score,
                "task_count" => GetModelSortBy.TaskCount,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListInternalRunsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to sort by<br/>
    /// Default Value: created_at
    /// </summary>
    public enum ListInternalRunsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInternalRunsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternalRunsOrderBy value)
        {
            return value switch
            {
                ListInternalRunsOrderBy.CreatedAt => "created_at",
                ListInternalRunsOrderBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternalRunsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListInternalRunsOrderBy.CreatedAt,
                "duration" => ListInternalRunsOrderBy.Duration,
                _ => null,
            };
        }
    }
}
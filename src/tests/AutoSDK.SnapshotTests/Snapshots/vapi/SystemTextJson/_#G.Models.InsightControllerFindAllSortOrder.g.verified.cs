//HintName: G.Models.InsightControllerFindAllSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerFindAllSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InsightControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerFindAllSortOrder value)
        {
            return value switch
            {
                InsightControllerFindAllSortOrder.Asc => "ASC",
                InsightControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => InsightControllerFindAllSortOrder.Asc,
                "DESC" => InsightControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}
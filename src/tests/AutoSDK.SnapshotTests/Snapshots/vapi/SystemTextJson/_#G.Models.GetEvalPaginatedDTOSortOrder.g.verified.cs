//HintName: G.Models.GetEvalPaginatedDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    public enum GetEvalPaginatedDTOSortOrder
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
    public static class GetEvalPaginatedDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalPaginatedDTOSortOrder value)
        {
            return value switch
            {
                GetEvalPaginatedDTOSortOrder.Asc => "ASC",
                GetEvalPaginatedDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalPaginatedDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetEvalPaginatedDTOSortOrder.Asc,
                "DESC" => GetEvalPaginatedDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}
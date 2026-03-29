//HintName: G.Models.ListExportRequestsV2SortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListExportRequestsV2SortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsV2SortOrder value)
        {
            return value switch
            {
                ListExportRequestsV2SortOrder.Ascending => "ascending",
                ListExportRequestsV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListExportRequestsV2SortOrder.Ascending,
                "descending" => ListExportRequestsV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}
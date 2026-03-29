//HintName: G.Models.ListBatchesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for jobs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListBatchesOrder
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
    public static class ListBatchesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchesOrder value)
        {
            return value switch
            {
                ListBatchesOrder.Asc => "asc",
                ListBatchesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListBatchesOrder.Asc,
                "desc" => ListBatchesOrder.Desc,
                _ => null,
            };
        }
    }
}
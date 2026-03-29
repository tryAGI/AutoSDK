//HintName: G.Models.ListBlocksOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    public enum ListBlocksOrder
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
    public static class ListBlocksOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBlocksOrder value)
        {
            return value switch
            {
                ListBlocksOrder.Asc => "asc",
                ListBlocksOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBlocksOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListBlocksOrder.Asc,
                "desc" => ListBlocksOrder.Desc,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListCoreMemoryBlocksOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListCoreMemoryBlocksOrder
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
    public static class ListCoreMemoryBlocksOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCoreMemoryBlocksOrder value)
        {
            return value switch
            {
                ListCoreMemoryBlocksOrder.Asc => "asc",
                ListCoreMemoryBlocksOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCoreMemoryBlocksOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListCoreMemoryBlocksOrder.Asc,
                "desc" => ListCoreMemoryBlocksOrder.Desc,
                _ => null,
            };
        }
    }
}
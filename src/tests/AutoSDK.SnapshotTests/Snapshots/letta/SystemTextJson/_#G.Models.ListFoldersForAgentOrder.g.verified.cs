//HintName: G.Models.ListFoldersForAgentOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for sources by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListFoldersForAgentOrder
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
    public static class ListFoldersForAgentOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFoldersForAgentOrder value)
        {
            return value switch
            {
                ListFoldersForAgentOrder.Asc => "asc",
                ListFoldersForAgentOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFoldersForAgentOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFoldersForAgentOrder.Asc,
                "desc" => ListFoldersForAgentOrder.Desc,
                _ => null,
            };
        }
    }
}
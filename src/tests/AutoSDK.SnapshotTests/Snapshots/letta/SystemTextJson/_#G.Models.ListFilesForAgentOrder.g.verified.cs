//HintName: G.Models.ListFilesForAgentOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for files by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListFilesForAgentOrder
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
    public static class ListFilesForAgentOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesForAgentOrder value)
        {
            return value switch
            {
                ListFilesForAgentOrder.Asc => "asc",
                ListFilesForAgentOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesForAgentOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFilesForAgentOrder.Asc,
                "desc" => ListFilesForAgentOrder.Desc,
                _ => null,
            };
        }
    }
}
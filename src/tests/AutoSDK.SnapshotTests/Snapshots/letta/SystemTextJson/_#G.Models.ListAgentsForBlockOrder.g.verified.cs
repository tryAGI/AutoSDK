//HintName: G.Models.ListAgentsForBlockOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListAgentsForBlockOrder
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
    public static class ListAgentsForBlockOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForBlockOrder value)
        {
            return value switch
            {
                ListAgentsForBlockOrder.Asc => "asc",
                ListAgentsForBlockOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForBlockOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAgentsForBlockOrder.Asc,
                "desc" => ListAgentsForBlockOrder.Desc,
                _ => null,
            };
        }
    }
}
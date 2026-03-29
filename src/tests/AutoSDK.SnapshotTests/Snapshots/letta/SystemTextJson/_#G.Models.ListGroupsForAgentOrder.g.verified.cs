//HintName: G.Models.ListGroupsForAgentOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for groups by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListGroupsForAgentOrder
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
    public static class ListGroupsForAgentOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGroupsForAgentOrder value)
        {
            return value switch
            {
                ListGroupsForAgentOrder.Asc => "asc",
                ListGroupsForAgentOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGroupsForAgentOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListGroupsForAgentOrder.Asc,
                "desc" => ListGroupsForAgentOrder.Desc,
                _ => null,
            };
        }
    }
}
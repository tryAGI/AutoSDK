//HintName: G.Models.ListGroupsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for groups by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    public enum ListGroupsOrder
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
    public static class ListGroupsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGroupsOrder value)
        {
            return value switch
            {
                ListGroupsOrder.Asc => "asc",
                ListGroupsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGroupsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListGroupsOrder.Asc,
                "desc" => ListGroupsOrder.Desc,
                _ => null,
            };
        }
    }
}
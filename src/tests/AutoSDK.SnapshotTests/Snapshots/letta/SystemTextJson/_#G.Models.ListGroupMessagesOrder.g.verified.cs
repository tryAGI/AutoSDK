//HintName: G.Models.ListGroupMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListGroupMessagesOrder
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
    public static class ListGroupMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGroupMessagesOrder value)
        {
            return value switch
            {
                ListGroupMessagesOrder.Asc => "asc",
                ListGroupMessagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGroupMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListGroupMessagesOrder.Asc,
                "desc" => ListGroupMessagesOrder.Desc,
                _ => null,
            };
        }
    }
}
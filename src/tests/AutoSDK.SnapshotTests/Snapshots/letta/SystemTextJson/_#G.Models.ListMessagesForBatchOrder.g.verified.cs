//HintName: G.Models.ListMessagesForBatchOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListMessagesForBatchOrder
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
    public static class ListMessagesForBatchOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessagesForBatchOrder value)
        {
            return value switch
            {
                ListMessagesForBatchOrder.Asc => "asc",
                ListMessagesForBatchOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessagesForBatchOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessagesForBatchOrder.Asc,
                "desc" => ListMessagesForBatchOrder.Desc,
                _ => null,
            };
        }
    }
}
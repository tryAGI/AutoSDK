//HintName: G.Models.MemoriesHistoryListResponseItemEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of event that occurred
    /// </summary>
    public enum MemoriesHistoryListResponseItemEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesHistoryListResponseItemEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesHistoryListResponseItemEvent value)
        {
            return value switch
            {
                MemoriesHistoryListResponseItemEvent.Add => "ADD",
                MemoriesHistoryListResponseItemEvent.Delete => "DELETE",
                MemoriesHistoryListResponseItemEvent.Update => "UPDATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesHistoryListResponseItemEvent? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => MemoriesHistoryListResponseItemEvent.Add,
                "DELETE" => MemoriesHistoryListResponseItemEvent.Delete,
                "UPDATE" => MemoriesHistoryListResponseItemEvent.Update,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListBatchJobsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchJobsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchJobsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchJobsSortBy value)
        {
            return value switch
            {
                ListBatchJobsSortBy.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchJobsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created" => ListBatchJobsSortBy.Created,
                _ => null,
            };
        }
    }
}
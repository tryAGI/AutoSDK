//HintName: G.Models.ListChatSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListChatSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListChatSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatSortOrder value)
        {
            return value switch
            {
                ListChatSortOrder.Ascending => "ascending",
                ListChatSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListChatSortOrder.Ascending,
                "descending" => ListChatSortOrder.Descending,
                _ => null,
            };
        }
    }
}
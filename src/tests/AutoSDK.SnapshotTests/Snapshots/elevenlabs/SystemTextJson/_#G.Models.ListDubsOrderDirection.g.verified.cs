//HintName: G.Models.ListDubsOrderDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The order direction to use for results from this query.<br/>
    /// Default Value: DESCENDING
    /// </summary>
    public enum ListDubsOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Descending,
        /// <summary>
        /// 
        /// </summary>
        Ascending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsOrderDirection value)
        {
            return value switch
            {
                ListDubsOrderDirection.Descending => "DESCENDING",
                ListDubsOrderDirection.Ascending => "ASCENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "DESCENDING" => ListDubsOrderDirection.Descending,
                "ASCENDING" => ListDubsOrderDirection.Ascending,
                _ => null,
            };
        }
    }
}
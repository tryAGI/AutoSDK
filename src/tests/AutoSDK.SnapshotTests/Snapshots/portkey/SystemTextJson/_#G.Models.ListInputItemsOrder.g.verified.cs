//HintName: G.Models.ListInputItemsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListInputItemsOrder
    {
        /// <summary>
        /// Return the input items in ascending order.
        /// </summary>
        Asc,
        /// <summary>
        /// Return the input items in descending order.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInputItemsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInputItemsOrder value)
        {
            return value switch
            {
                ListInputItemsOrder.Asc => "asc",
                ListInputItemsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInputItemsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListInputItemsOrder.Asc,
                "desc" => ListInputItemsOrder.Desc,
                _ => null,
            };
        }
    }
}
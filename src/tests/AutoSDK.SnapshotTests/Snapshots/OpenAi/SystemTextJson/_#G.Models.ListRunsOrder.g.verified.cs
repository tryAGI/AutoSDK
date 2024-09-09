//HintName: G.Models.ListRunsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListRunsOrder
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
    public static class ListRunsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRunsOrder value)
        {
            return value switch
            {
                ListRunsOrder.Asc => "asc",
                ListRunsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRunsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListRunsOrder.Asc,
                "desc" => ListRunsOrder.Desc,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListFlowsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlowsOrder
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
    public static class ListFlowsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlowsOrder value)
        {
            return value switch
            {
                ListFlowsOrder.Asc => "asc",
                ListFlowsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlowsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFlowsOrder.Asc,
                "desc" => ListFlowsOrder.Desc,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListToolsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListToolsOrder
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
    public static class ListToolsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolsOrder value)
        {
            return value switch
            {
                ListToolsOrder.Asc => "asc",
                ListToolsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListToolsOrder.Asc,
                "desc" => ListToolsOrder.Desc,
                _ => null,
            };
        }
    }
}
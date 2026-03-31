//HintName: G.Models.ListMyAgentsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMyAgentsOrder
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
    public static class ListMyAgentsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsOrder value)
        {
            return value switch
            {
                ListMyAgentsOrder.Ascending => "ascending",
                ListMyAgentsOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListMyAgentsOrder.Ascending,
                "descending" => ListMyAgentsOrder.Descending,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.EvalStatusPageConfigSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order (ascending or descending)
    /// </summary>
    public enum EvalStatusPageConfigSortOrder
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
    public static class EvalStatusPageConfigSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalStatusPageConfigSortOrder value)
        {
            return value switch
            {
                EvalStatusPageConfigSortOrder.Asc => "asc",
                EvalStatusPageConfigSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalStatusPageConfigSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => EvalStatusPageConfigSortOrder.Asc,
                "desc" => EvalStatusPageConfigSortOrder.Desc,
                _ => null,
            };
        }
    }
}
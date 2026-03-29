//HintName: G.Models.ListStepsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for steps by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListStepsOrder
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
    public static class ListStepsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStepsOrder value)
        {
            return value switch
            {
                ListStepsOrder.Asc => "asc",
                ListStepsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStepsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListStepsOrder.Asc,
                "desc" => ListStepsOrder.Desc,
                _ => null,
            };
        }
    }
}
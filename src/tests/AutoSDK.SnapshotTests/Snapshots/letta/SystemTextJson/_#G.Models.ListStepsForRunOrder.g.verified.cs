//HintName: G.Models.ListStepsForRunOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for steps by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListStepsForRunOrder
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
    public static class ListStepsForRunOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStepsForRunOrder value)
        {
            return value switch
            {
                ListStepsForRunOrder.Asc => "asc",
                ListStepsForRunOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStepsForRunOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListStepsForRunOrder.Asc,
                "desc" => ListStepsForRunOrder.Desc,
                _ => null,
            };
        }
    }
}
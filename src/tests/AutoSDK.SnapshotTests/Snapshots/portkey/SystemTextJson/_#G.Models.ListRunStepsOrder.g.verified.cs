//HintName: G.Models.ListRunStepsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListRunStepsOrder
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
    public static class ListRunStepsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRunStepsOrder value)
        {
            return value switch
            {
                ListRunStepsOrder.Asc => "asc",
                ListRunStepsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRunStepsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListRunStepsOrder.Asc,
                "desc" => ListRunStepsOrder.Desc,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RunDateOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run start date order.
    /// </summary>
    public enum RunDateOrder
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
    public static class RunDateOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunDateOrder value)
        {
            return value switch
            {
                RunDateOrder.Asc => "asc",
                RunDateOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunDateOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => RunDateOrder.Asc,
                "desc" => RunDateOrder.Desc,
                _ => null,
            };
        }
    }
}
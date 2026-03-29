//HintName: G.Models.StringFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// eq: equal, ne: not equal, sw: starts with, ew: ends with, co: contains
    /// </summary>
    public enum StringFilterOp
    {
        /// <summary>
        /// equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        Co,
        /// <summary>
        /// equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        Eq,
        /// <summary>
        /// equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        Ew,
        /// <summary>
        /// equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        Ne,
        /// <summary>
        /// equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        Sw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StringFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringFilterOp value)
        {
            return value switch
            {
                StringFilterOp.Co => "co",
                StringFilterOp.Eq => "eq",
                StringFilterOp.Ew => "ew",
                StringFilterOp.Ne => "ne",
                StringFilterOp.Sw => "sw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "co" => StringFilterOp.Co,
                "eq" => StringFilterOp.Eq,
                "ew" => StringFilterOp.Ew,
                "ne" => StringFilterOp.Ne,
                "sw" => StringFilterOp.Sw,
                _ => null,
            };
        }
    }
}
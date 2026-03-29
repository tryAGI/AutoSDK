//HintName: G.Models.QaViewFilterScoreRangeOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum QaViewFilterScoreRangeOp
    {
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QaViewFilterScoreRangeOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QaViewFilterScoreRangeOp value)
        {
            return value switch
            {
                QaViewFilterScoreRangeOp.Ge => "ge",
                QaViewFilterScoreRangeOp.Gt => "gt",
                QaViewFilterScoreRangeOp.Gte => "gte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QaViewFilterScoreRangeOp? ToEnum(string value)
        {
            return value switch
            {
                "ge" => QaViewFilterScoreRangeOp.Ge,
                "gt" => QaViewFilterScoreRangeOp.Gt,
                "gte" => QaViewFilterScoreRangeOp.Gte,
                _ => null,
            };
        }
    }
}
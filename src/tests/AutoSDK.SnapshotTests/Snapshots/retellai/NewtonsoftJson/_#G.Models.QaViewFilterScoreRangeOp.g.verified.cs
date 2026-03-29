//HintName: G.Models.QaViewFilterScoreRangeOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum QaViewFilterScoreRangeOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte")]
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
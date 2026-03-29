//HintName: G.Models.QaViewFilterScoreRangeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum QaViewFilterScoreRangeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QaViewFilterScoreRangeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QaViewFilterScoreRangeType value)
        {
            return value switch
            {
                QaViewFilterScoreRangeType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QaViewFilterScoreRangeType? ToEnum(string value)
        {
            return value switch
            {
                "number" => QaViewFilterScoreRangeType.Number,
                _ => null,
            };
        }
    }
}
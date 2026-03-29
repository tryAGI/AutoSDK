//HintName: G.Models.ScoreV1Variant2DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoreV1Variant2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATEGORICAL")]
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1Variant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1Variant2DataType value)
        {
            return value switch
            {
                ScoreV1Variant2DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1Variant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => ScoreV1Variant2DataType.Categorical,
                _ => null,
            };
        }
    }
}
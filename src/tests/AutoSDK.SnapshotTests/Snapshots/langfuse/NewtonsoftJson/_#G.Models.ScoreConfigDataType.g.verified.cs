//HintName: G.Models.ScoreConfigDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoreConfigDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOOLEAN")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATEGORICAL")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NUMERIC")]
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreConfigDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConfigDataType value)
        {
            return value switch
            {
                ScoreConfigDataType.Boolean => "BOOLEAN",
                ScoreConfigDataType.Categorical => "CATEGORICAL",
                ScoreConfigDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConfigDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreConfigDataType.Boolean,
                "CATEGORICAL" => ScoreConfigDataType.Categorical,
                "NUMERIC" => ScoreConfigDataType.Numeric,
                _ => null,
            };
        }
    }
}
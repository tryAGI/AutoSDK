//HintName: G.Models.ScoreVariant4DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoreVariant4DataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CORRECTION")]
        Correction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreVariant4DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreVariant4DataType value)
        {
            return value switch
            {
                ScoreVariant4DataType.Correction => "CORRECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreVariant4DataType? ToEnum(string value)
        {
            return value switch
            {
                "CORRECTION" => ScoreVariant4DataType.Correction,
                _ => null,
            };
        }
    }
}
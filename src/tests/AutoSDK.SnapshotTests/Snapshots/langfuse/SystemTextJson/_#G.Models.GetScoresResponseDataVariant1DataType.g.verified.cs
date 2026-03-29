//HintName: G.Models.GetScoresResponseDataVariant1DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScoresResponseDataVariant1DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataVariant1DataType value)
        {
            return value switch
            {
                GetScoresResponseDataVariant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => GetScoresResponseDataVariant1DataType.Numeric,
                _ => null,
            };
        }
    }
}
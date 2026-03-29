//HintName: G.Models.GetScoresResponseDataVariant2DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScoresResponseDataVariant2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataVariant2DataType value)
        {
            return value switch
            {
                GetScoresResponseDataVariant2DataType.Categorical => "CATEGORICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => GetScoresResponseDataVariant2DataType.Categorical,
                _ => null,
            };
        }
    }
}
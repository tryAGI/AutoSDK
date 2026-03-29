//HintName: G.Models.GetScoresResponseDataVariant3DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScoresResponseDataVariant3DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetScoresResponseDataVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScoresResponseDataVariant3DataType value)
        {
            return value switch
            {
                GetScoresResponseDataVariant3DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScoresResponseDataVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => GetScoresResponseDataVariant3DataType.Boolean,
                _ => null,
            };
        }
    }
}
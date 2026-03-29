//HintName: G.Models.NumberAnalysisDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the variable to extract.<br/>
    /// Example: number
    /// </summary>
    public enum NumberAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NumberAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NumberAnalysisDataType value)
        {
            return value switch
            {
                NumberAnalysisDataType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NumberAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "number" => NumberAnalysisDataType.Number,
                _ => null,
            };
        }
    }
}
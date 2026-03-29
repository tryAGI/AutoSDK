//HintName: G.Models.StringAnalysisDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the variable to extract.<br/>
    /// Example: string
    /// </summary>
    public enum StringAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StringAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringAnalysisDataType value)
        {
            return value switch
            {
                StringAnalysisDataType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "string" => StringAnalysisDataType.String,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.EnumAnalysisDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the variable to extract.<br/>
    /// Example: enum
    /// </summary>
    public enum EnumAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnumAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnumAnalysisDataType value)
        {
            return value switch
            {
                EnumAnalysisDataType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnumAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => EnumAnalysisDataType.Enum,
                _ => null,
            };
        }
    }
}
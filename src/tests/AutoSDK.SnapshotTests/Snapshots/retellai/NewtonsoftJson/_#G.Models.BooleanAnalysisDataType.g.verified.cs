//HintName: G.Models.BooleanAnalysisDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the variable to extract.<br/>
    /// Example: boolean
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BooleanAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BooleanAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BooleanAnalysisDataType value)
        {
            return value switch
            {
                BooleanAnalysisDataType.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BooleanAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => BooleanAnalysisDataType.Boolean,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ExtractDynamicVariableToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractDynamicVariableToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extract_dynamic_variable")]
        ExtractDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractDynamicVariableToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractDynamicVariableToolType value)
        {
            return value switch
            {
                ExtractDynamicVariableToolType.ExtractDynamicVariable => "extract_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractDynamicVariableToolType? ToEnum(string value)
        {
            return value switch
            {
                "extract_dynamic_variable" => ExtractDynamicVariableToolType.ExtractDynamicVariable,
                _ => null,
            };
        }
    }
}
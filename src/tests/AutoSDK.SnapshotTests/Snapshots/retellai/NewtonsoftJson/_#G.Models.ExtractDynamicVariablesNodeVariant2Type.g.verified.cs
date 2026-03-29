//HintName: G.Models.ExtractDynamicVariablesNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractDynamicVariablesNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extract_dynamic_variables")]
        ExtractDynamicVariables,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractDynamicVariablesNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractDynamicVariablesNodeVariant2Type value)
        {
            return value switch
            {
                ExtractDynamicVariablesNodeVariant2Type.ExtractDynamicVariables => "extract_dynamic_variables",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractDynamicVariablesNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "extract_dynamic_variables" => ExtractDynamicVariablesNodeVariant2Type.ExtractDynamicVariables,
                _ => null,
            };
        }
    }
}
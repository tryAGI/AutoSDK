//HintName: G.Models.FunctionDataParametersSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataParametersSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataParametersSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataParametersSchemaType value)
        {
            return value switch
            {
                FunctionDataParametersSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataParametersSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => FunctionDataParametersSchemaType.Object,
                _ => null,
            };
        }
    }
}
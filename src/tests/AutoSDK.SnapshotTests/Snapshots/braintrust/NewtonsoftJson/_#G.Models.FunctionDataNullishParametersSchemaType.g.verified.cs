//HintName: G.Models.FunctionDataNullishParametersSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataNullishParametersSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishParametersSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishParametersSchemaType value)
        {
            return value switch
            {
                FunctionDataNullishParametersSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishParametersSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => FunctionDataNullishParametersSchemaType.Object,
                _ => null,
            };
        }
    }
}
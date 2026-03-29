//HintName: G.Models.FunctionDataNullishParametersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataNullishParametersType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parameters")]
        Parameters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishParametersType value)
        {
            return value switch
            {
                FunctionDataNullishParametersType.Parameters => "parameters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishParametersType? ToEnum(string value)
        {
            return value switch
            {
                "parameters" => FunctionDataNullishParametersType.Parameters,
                _ => null,
            };
        }
    }
}
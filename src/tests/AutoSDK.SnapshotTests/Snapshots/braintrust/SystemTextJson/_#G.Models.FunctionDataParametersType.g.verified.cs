//HintName: G.Models.FunctionDataParametersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataParametersType
    {
        /// <summary>
        /// 
        /// </summary>
        Parameters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataParametersType value)
        {
            return value switch
            {
                FunctionDataParametersType.Parameters => "parameters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataParametersType? ToEnum(string value)
        {
            return value switch
            {
                "parameters" => FunctionDataParametersType.Parameters,
                _ => null,
            };
        }
    }
}
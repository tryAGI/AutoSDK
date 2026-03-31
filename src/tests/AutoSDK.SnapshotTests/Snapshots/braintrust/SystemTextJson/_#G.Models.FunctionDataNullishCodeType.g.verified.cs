//HintName: G.Models.FunctionDataNullishCodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataNullishCodeType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishCodeType value)
        {
            return value switch
            {
                FunctionDataNullishCodeType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishCodeType? ToEnum(string value)
        {
            return value switch
            {
                "code" => FunctionDataNullishCodeType.Code,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.FunctionDataNullishCodeDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataNullishCodeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bundle")]
        Bundle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishCodeDataType value)
        {
            return value switch
            {
                FunctionDataNullishCodeDataType.Bundle => "bundle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundle" => FunctionDataNullishCodeDataType.Bundle,
                _ => null,
            };
        }
    }
}
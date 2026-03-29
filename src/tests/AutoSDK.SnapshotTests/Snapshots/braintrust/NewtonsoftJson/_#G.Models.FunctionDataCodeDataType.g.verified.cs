//HintName: G.Models.FunctionDataCodeDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataCodeDataType
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
    public static class FunctionDataCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataCodeDataType value)
        {
            return value switch
            {
                FunctionDataCodeDataType.Bundle => "bundle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundle" => FunctionDataCodeDataType.Bundle,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.NullableSavedFunctionIdFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableSavedFunctionIdFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableSavedFunctionIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableSavedFunctionIdFunctionType value)
        {
            return value switch
            {
                NullableSavedFunctionIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableSavedFunctionIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => NullableSavedFunctionIdFunctionType.Function,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.NullableSavedFunctionIdGlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableSavedFunctionIdGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableSavedFunctionIdGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableSavedFunctionIdGlobalType value)
        {
            return value switch
            {
                NullableSavedFunctionIdGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableSavedFunctionIdGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => NullableSavedFunctionIdGlobalType.Global,
                _ => null,
            };
        }
    }
}
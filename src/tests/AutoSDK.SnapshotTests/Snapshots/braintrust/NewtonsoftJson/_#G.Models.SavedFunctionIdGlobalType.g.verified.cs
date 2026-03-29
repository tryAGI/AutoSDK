//HintName: G.Models.SavedFunctionIdGlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SavedFunctionIdGlobalType
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
    public static class SavedFunctionIdGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedFunctionIdGlobalType value)
        {
            return value switch
            {
                SavedFunctionIdGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedFunctionIdGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => SavedFunctionIdGlobalType.Global,
                _ => null,
            };
        }
    }
}
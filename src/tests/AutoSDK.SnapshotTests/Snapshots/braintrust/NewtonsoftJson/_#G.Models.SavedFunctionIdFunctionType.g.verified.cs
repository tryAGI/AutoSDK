//HintName: G.Models.SavedFunctionIdFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SavedFunctionIdFunctionType
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
    public static class SavedFunctionIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedFunctionIdFunctionType value)
        {
            return value switch
            {
                SavedFunctionIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedFunctionIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => SavedFunctionIdFunctionType.Function,
                _ => null,
            };
        }
    }
}
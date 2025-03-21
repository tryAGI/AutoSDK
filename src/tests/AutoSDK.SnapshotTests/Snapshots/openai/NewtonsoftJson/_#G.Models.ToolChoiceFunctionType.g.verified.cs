//HintName: G.Models.ToolChoiceFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For function calling, the type is always `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolChoiceFunctionType
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
    public static class ToolChoiceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceFunctionType value)
        {
            return value switch
            {
                ToolChoiceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolChoiceFunctionType.Function,
                _ => null,
            };
        }
    }
}
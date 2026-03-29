//HintName: G.Models.FunctionToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "function" for Function tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionToolWithToolCallType
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
    public static class FunctionToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolWithToolCallType value)
        {
            return value switch
            {
                FunctionToolWithToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionToolWithToolCallType.Function,
                _ => null,
            };
        }
    }
}
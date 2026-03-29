//HintName: G.Models.TopicMapFunctionAutomationFunctionVariant2FunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicMapFunctionAutomationFunctionVariant2FunctionType
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
    public static class TopicMapFunctionAutomationFunctionVariant2FunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapFunctionAutomationFunctionVariant2FunctionType value)
        {
            return value switch
            {
                TopicMapFunctionAutomationFunctionVariant2FunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapFunctionAutomationFunctionVariant2FunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => TopicMapFunctionAutomationFunctionVariant2FunctionType.Function,
                _ => null,
            };
        }
    }
}
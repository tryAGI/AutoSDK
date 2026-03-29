//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetInternalActionExecutionLogByIdResponseStepType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fetch_connection_details")]
        FetchConnectionDetails,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_execution")]
        ToolExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInternalActionExecutionLogByIdResponseStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalActionExecutionLogByIdResponseStepType value)
        {
            return value switch
            {
                GetInternalActionExecutionLogByIdResponseStepType.FetchConnectionDetails => "fetch_connection_details",
                GetInternalActionExecutionLogByIdResponseStepType.ToolExecution => "tool_execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalActionExecutionLogByIdResponseStepType? ToEnum(string value)
        {
            return value switch
            {
                "fetch_connection_details" => GetInternalActionExecutionLogByIdResponseStepType.FetchConnectionDetails,
                "tool_execution" => GetInternalActionExecutionLogByIdResponseStepType.ToolExecution,
                _ => null,
            };
        }
    }
}
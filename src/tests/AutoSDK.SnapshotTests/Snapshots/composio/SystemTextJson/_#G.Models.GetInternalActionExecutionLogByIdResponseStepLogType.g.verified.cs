//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepLogType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetInternalActionExecutionLogByIdResponseStepLogType
    {
        /// <summary>
        /// 
        /// </summary>
        Network,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInternalActionExecutionLogByIdResponseStepLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalActionExecutionLogByIdResponseStepLogType value)
        {
            return value switch
            {
                GetInternalActionExecutionLogByIdResponseStepLogType.Network => "network",
                GetInternalActionExecutionLogByIdResponseStepLogType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalActionExecutionLogByIdResponseStepLogType? ToEnum(string value)
        {
            return value switch
            {
                "network" => GetInternalActionExecutionLogByIdResponseStepLogType.Network,
                "system" => GetInternalActionExecutionLogByIdResponseStepLogType.System,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetInternalActionExecutionLogByIdResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInternalActionExecutionLogByIdResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalActionExecutionLogByIdResponseStatus value)
        {
            return value switch
            {
                GetInternalActionExecutionLogByIdResponseStatus.Error => "error",
                GetInternalActionExecutionLogByIdResponseStatus.Info => "info",
                GetInternalActionExecutionLogByIdResponseStatus.Success => "success",
                GetInternalActionExecutionLogByIdResponseStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalActionExecutionLogByIdResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetInternalActionExecutionLogByIdResponseStatus.Error,
                "info" => GetInternalActionExecutionLogByIdResponseStatus.Info,
                "success" => GetInternalActionExecutionLogByIdResponseStatus.Success,
                "warning" => GetInternalActionExecutionLogByIdResponseStatus.Warning,
                _ => null,
            };
        }
    }
}
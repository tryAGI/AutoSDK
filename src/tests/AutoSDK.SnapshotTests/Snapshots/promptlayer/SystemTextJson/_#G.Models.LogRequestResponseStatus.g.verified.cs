//HintName: G.Models.LogRequestResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request status indicating success, warning, or error.
    /// </summary>
    public enum LogRequestResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
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
    public static class LogRequestResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestResponseStatus value)
        {
            return value switch
            {
                LogRequestResponseStatus.Error => "ERROR",
                LogRequestResponseStatus.Success => "SUCCESS",
                LogRequestResponseStatus.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => LogRequestResponseStatus.Error,
                "SUCCESS" => LogRequestResponseStatus.Success,
                "WARNING" => LogRequestResponseStatus.Warning,
                _ => null,
            };
        }
    }
}
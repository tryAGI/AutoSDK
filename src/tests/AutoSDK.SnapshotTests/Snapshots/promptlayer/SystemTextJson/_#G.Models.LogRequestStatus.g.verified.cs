//HintName: G.Models.LogRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request status.<br/>
    /// | Value | Description |<br/>
    /// |-------|-------------|<br/>
    /// | `SUCCESS` | Request completed successfully (default) |<br/>
    /// | `WARNING` | Request succeeded but had issues (e.g., retries, degraded response) |<br/>
    /// | `ERROR` | Request failed |<br/>
    /// Default Value: SUCCESS
    /// </summary>
    public enum LogRequestStatus
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
    public static class LogRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestStatus value)
        {
            return value switch
            {
                LogRequestStatus.Error => "ERROR",
                LogRequestStatus.Success => "SUCCESS",
                LogRequestStatus.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => LogRequestStatus.Error,
                "SUCCESS" => LogRequestStatus.Success,
                "WARNING" => LogRequestStatus.Warning,
                _ => null,
            };
        }
    }
}
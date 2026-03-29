//HintName: G.Models.LogsDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction of the logs that should be returned
    /// </summary>
    public enum LogsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        LogsDirectionBackward,
        /// <summary>
        /// 
        /// </summary>
        LogsDirectionForward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogsDirection value)
        {
            return value switch
            {
                LogsDirection.LogsDirectionBackward => "backward",
                LogsDirection.LogsDirectionForward => "forward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogsDirection? ToEnum(string value)
        {
            return value switch
            {
                "backward" => LogsDirection.LogsDirectionBackward,
                "forward" => LogsDirection.LogsDirectionForward,
                _ => null,
            };
        }
    }
}
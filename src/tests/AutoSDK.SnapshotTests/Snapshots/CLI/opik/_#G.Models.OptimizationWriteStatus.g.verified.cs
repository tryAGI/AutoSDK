//HintName: G.Models.OptimizationWriteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizationWriteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Initialized,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptimizationWriteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationWriteStatus value)
        {
            return value switch
            {
                OptimizationWriteStatus.Cancelled => "cancelled",
                OptimizationWriteStatus.Completed => "completed",
                OptimizationWriteStatus.Error => "error",
                OptimizationWriteStatus.Initialized => "initialized",
                OptimizationWriteStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationWriteStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OptimizationWriteStatus.Cancelled,
                "completed" => OptimizationWriteStatus.Completed,
                "error" => OptimizationWriteStatus.Error,
                "initialized" => OptimizationWriteStatus.Initialized,
                "running" => OptimizationWriteStatus.Running,
                _ => null,
            };
        }
    }
}
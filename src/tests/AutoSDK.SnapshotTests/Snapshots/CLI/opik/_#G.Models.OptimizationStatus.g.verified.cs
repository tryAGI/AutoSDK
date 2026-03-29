//HintName: G.Models.OptimizationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizationStatus
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
    public static class OptimizationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationStatus value)
        {
            return value switch
            {
                OptimizationStatus.Cancelled => "cancelled",
                OptimizationStatus.Completed => "completed",
                OptimizationStatus.Error => "error",
                OptimizationStatus.Initialized => "initialized",
                OptimizationStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OptimizationStatus.Cancelled,
                "completed" => OptimizationStatus.Completed,
                "error" => OptimizationStatus.Error,
                "initialized" => OptimizationStatus.Initialized,
                "running" => OptimizationStatus.Running,
                _ => null,
            };
        }
    }
}
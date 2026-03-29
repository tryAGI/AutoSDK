//HintName: G.Models.OptimizationUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizationUpdateStatus
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
    public static class OptimizationUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationUpdateStatus value)
        {
            return value switch
            {
                OptimizationUpdateStatus.Cancelled => "cancelled",
                OptimizationUpdateStatus.Completed => "completed",
                OptimizationUpdateStatus.Error => "error",
                OptimizationUpdateStatus.Initialized => "initialized",
                OptimizationUpdateStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OptimizationUpdateStatus.Cancelled,
                "completed" => OptimizationUpdateStatus.Completed,
                "error" => OptimizationUpdateStatus.Error,
                "initialized" => OptimizationUpdateStatus.Initialized,
                "running" => OptimizationUpdateStatus.Running,
                _ => null,
            };
        }
    }
}
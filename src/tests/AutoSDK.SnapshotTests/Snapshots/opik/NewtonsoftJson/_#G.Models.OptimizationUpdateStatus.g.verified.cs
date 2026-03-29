//HintName: G.Models.OptimizationUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OptimizationUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initialized")]
        Initialized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
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
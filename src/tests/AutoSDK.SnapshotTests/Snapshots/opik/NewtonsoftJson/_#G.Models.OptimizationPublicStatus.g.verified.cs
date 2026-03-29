//HintName: G.Models.OptimizationPublicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OptimizationPublicStatus
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
    public static class OptimizationPublicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationPublicStatus value)
        {
            return value switch
            {
                OptimizationPublicStatus.Cancelled => "cancelled",
                OptimizationPublicStatus.Completed => "completed",
                OptimizationPublicStatus.Error => "error",
                OptimizationPublicStatus.Initialized => "initialized",
                OptimizationPublicStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationPublicStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OptimizationPublicStatus.Cancelled,
                "completed" => OptimizationPublicStatus.Completed,
                "error" => OptimizationPublicStatus.Error,
                "initialized" => OptimizationPublicStatus.Initialized,
                "running" => OptimizationPublicStatus.Running,
                _ => null,
            };
        }
    }
}
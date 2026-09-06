//HintName: G.Models.StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of a step execution
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepStatus value)
        {
            return value switch
            {
                StepStatus.Cancelled => "cancelled",
                StepStatus.Failed => "failed",
                StepStatus.Pending => "pending",
                StepStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => StepStatus.Cancelled,
                "failed" => StepStatus.Failed,
                "pending" => StepStatus.Pending,
                "success" => StepStatus.Success,
                _ => null,
            };
        }
    }
}
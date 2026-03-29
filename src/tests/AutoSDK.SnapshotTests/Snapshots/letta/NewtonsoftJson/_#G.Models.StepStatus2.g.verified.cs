//HintName: G.Models.StepStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of a step execution
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StepStatus2
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
    public static class StepStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepStatus2 value)
        {
            return value switch
            {
                StepStatus2.Cancelled => "cancelled",
                StepStatus2.Failed => "failed",
                StepStatus2.Pending => "pending",
                StepStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepStatus2? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => StepStatus2.Cancelled,
                "failed" => StepStatus2.Failed,
                "pending" => StepStatus2.Pending,
                "success" => StepStatus2.Success,
                _ => null,
            };
        }
    }
}
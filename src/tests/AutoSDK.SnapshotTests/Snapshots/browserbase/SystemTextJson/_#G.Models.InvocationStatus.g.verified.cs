//HintName: G.Models.InvocationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvocationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvocationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvocationStatus value)
        {
            return value switch
            {
                InvocationStatus.Completed => "COMPLETED",
                InvocationStatus.Failed => "FAILED",
                InvocationStatus.Pending => "PENDING",
                InvocationStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvocationStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => InvocationStatus.Completed,
                "FAILED" => InvocationStatus.Failed,
                "PENDING" => InvocationStatus.Pending,
                "RUNNING" => InvocationStatus.Running,
                _ => null,
            };
        }
    }
}
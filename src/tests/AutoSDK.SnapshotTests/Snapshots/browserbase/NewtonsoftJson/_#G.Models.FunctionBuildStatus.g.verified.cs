//HintName: G.Models.FunctionBuildStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionBuildStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionBuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionBuildStatus value)
        {
            return value switch
            {
                FunctionBuildStatus.Completed => "COMPLETED",
                FunctionBuildStatus.Failed => "FAILED",
                FunctionBuildStatus.Pending => "PENDING",
                FunctionBuildStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionBuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => FunctionBuildStatus.Completed,
                "FAILED" => FunctionBuildStatus.Failed,
                "PENDING" => FunctionBuildStatus.Pending,
                "RUNNING" => FunctionBuildStatus.Running,
                _ => null,
            };
        }
    }
}
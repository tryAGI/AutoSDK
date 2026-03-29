//HintName: G.Models.RemeshTaskStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemeshTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemeshTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemeshTaskStatus value)
        {
            return value switch
            {
                RemeshTaskStatus.Failed => "FAILED",
                RemeshTaskStatus.InProgress => "IN_PROGRESS",
                RemeshTaskStatus.Pending => "PENDING",
                RemeshTaskStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemeshTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => RemeshTaskStatus.Failed,
                "IN_PROGRESS" => RemeshTaskStatus.InProgress,
                "PENDING" => RemeshTaskStatus.Pending,
                "SUCCEEDED" => RemeshTaskStatus.Succeeded,
                _ => null,
            };
        }
    }
}